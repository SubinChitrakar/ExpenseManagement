using ExpenseManagement.Model;
using ExpenseManagement.Utilities;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Repository
{
    class EventRepository : BaseRepository
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();
        //Constructor
        public EventRepository() : base() { }

        public List<Event> GetEvents(int userId)
        {
            List<Event> eventList = new List<Event>();
            Query = "SELECT Events.*, Contacts.ContactName FROM Events LEFT JOIN Contacts ON Events.ContactId = Contacts.ContactId WHERE Events.UserId = @UserId ORDER BY Events.EventDate DESC";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Event normalEvent = new Event
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Location = sqlDataReader["Location"].ToString(),
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        EventDate = (DateTime)sqlDataReader["EventDate"],
                        UserId = (int)sqlDataReader["UserId"]
                    };

                    if (sqlDataReader["ContactId"] == DBNull.Value)
                        normalEvent.ContactId = 0;
                    else
                        normalEvent.ContactId = (int)sqlDataReader["ContactId"];


                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        normalEvent.ContactName = "";
                    else
                        normalEvent.ContactName = sqlDataReader["ContactName"].ToString();

                    eventList.Add(normalEvent);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            finally
            {
                SqlConnection.Close();
            }
            return eventList;
        }

        public MessageStatus AddEvent(Event newEvent)
        {
            Query = "INSERT INTO Events([Name], [Location], [Type], [Note], [EventDate], [ContactId], [UserId]) VALUES(@Name, @Location, @Type, @Note, @EventDate, @ContactId, @UserId);";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = newEvent.Name;
                sqlCommand.Parameters.Add("@Location", SqlDbType.VarChar).Value = newEvent.Location;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = newEvent.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = newEvent.Note;
                sqlCommand.Parameters.AddWithValue("@EventDate", SqlDbType.DateTime).Value = newEvent.EventDate;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = newEvent.UserId;

                SqlParameter contactId = new SqlParameter("ContactId", SqlDbType.Int);
                if (newEvent.ContactId == 0)
                    contactId.Value = DBNull.Value;
                else
                    contactId.Value = newEvent.ContactId;
                sqlCommand.Parameters.Add(contactId);


                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Event Added Successfully!!";
                    MessageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Added!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }
            return MessageStatus;
        }

        //Update Contact
        public MessageStatus UpdateEvent(Event updatingEvent)
        {
            Query = "UPDATE Events SET [Name] = @Name, [Location] = @Location, [Type] = @Type, [Note] = @Note, [EventDate] = @EventDate, [ContactId] = @ContactId WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = updatingEvent.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = UserSession.UserData.Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = updatingEvent.Name;
                sqlCommand.Parameters.Add("@Location", SqlDbType.VarChar).Value = updatingEvent.Location;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = updatingEvent.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = updatingEvent.Note;
                sqlCommand.Parameters.AddWithValue("@EventDate", SqlDbType.DateTime).Value = updatingEvent.EventDate;

                SqlParameter contactId = new SqlParameter("ContactId", SqlDbType.Int);
                if (updatingEvent.ContactId == 0)
                    contactId.Value = DBNull.Value;
                else
                    contactId.Value = updatingEvent.ContactId;
                sqlCommand.Parameters.Add(contactId);

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Event Updated Successfully!!";
                    MessageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Updated!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }

            return MessageStatus;
        }

        public MessageStatus DeleteEvent(Event deletingEvent)
        {
            Query = "DELETE FROM Events WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = deletingEvent.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = deletingEvent.UserId;

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Event Deleted Successfully!!";
                    MessageStatus.ErrorStatus = false;
                }
                else
                    throw new Exception("Error, Data Not Deleted!");
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }
            return MessageStatus;
        }
    }
}
