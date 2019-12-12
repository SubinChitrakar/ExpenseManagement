using ExpenseManagement.Model;
using ExpenseManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Repository
{
    class RecurringEventRepository : BaseRepository
    {
        //Constructor
        public RecurringEventRepository() : base() { }

        public List<RecurringEvent> GetEvents(int userId)
        {
            List<RecurringEvent> recurringEventList = new List<RecurringEvent>();
            Query = "SELECT RecurringEvents.*, Contacts.ContactName FROM RecurringEvents LEFT JOIN Contacts ON RecurringEvents.ContactId = Contacts.ContactId WHERE RecurringEvents.UserId = @UserId ORDER BY RecurringEvents.EventDate DESC";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    RecurringEvent recurringEvent = new RecurringEvent
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Location = sqlDataReader["Location"].ToString(),
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        EventDate = (DateTime)sqlDataReader["EventDate"],
                        Status = sqlDataReader["Status"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    };

                    if (sqlDataReader["ContactId"] == DBNull.Value)
                        recurringEvent.ContactId = 0;
                    else
                        recurringEvent.ContactId = (int)sqlDataReader["ContactId"];
                    
                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        recurringEvent.ContactName = "";
                    else
                        recurringEvent.ContactName = sqlDataReader["ContactName"].ToString();

                    if (sqlDataReader["EventEndDate"] == DBNull.Value)
                        recurringEvent.EventEndDate = DateTime.MinValue;
                    else
                        recurringEvent.EventEndDate = (DateTime)sqlDataReader["EventEndDate"];

                    recurringEventList.Add(recurringEvent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                SqlConnection.Close();
            }
            return recurringEventList;
        }

        public MessageStatus AddEvent(RecurringEvent newEvent)
        {
            Query = "INSERT INTO RecurringEvents([Name], [Location], [Type], [Note], [EventDate], [ContactId], [Status], [EventEndDate], [UserId]) VALUES(@Name, @Location, @Type, @Note, @EventDate, @ContactId, @Status, @EventEndDate, @UserId);";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = newEvent.Name;
                sqlCommand.Parameters.Add("@Location", SqlDbType.VarChar).Value = newEvent.Location;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = newEvent.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = newEvent.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = newEvent.Status;
                sqlCommand.Parameters.AddWithValue("@EventDate", SqlDbType.DateTime).Value = newEvent.EventDate;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = newEvent.UserId;

                SqlParameter contactId = new SqlParameter("ContactId", SqlDbType.Int);
                if (newEvent.ContactId == 0)
                    contactId.Value = DBNull.Value;
                else
                    contactId.Value = newEvent.ContactId;
                sqlCommand.Parameters.Add(contactId);

                SqlParameter eventEndDate = new SqlParameter("@EventEndDate", SqlDbType.DateTime);
                if (newEvent.EventEndDate == DateTime.MinValue)
                    eventEndDate.Value = DBNull.Value;
                else
                    eventEndDate.Value = newEvent.EventEndDate;
                sqlCommand.Parameters.Add(eventEndDate);

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
        public MessageStatus UpdateEvent(RecurringEvent updatingEvent)
        {
            Query = "UPDATE RecurringEvents SET [Name] = @Name, [Location] = @Location, [Type] = @Type, [Note] = @Note, [EventDate] = @EventDate, [ContactId] = @ContactId, [Status] = @Status, [EventEndDate] = @EventEndDate WHERE [Id] = @Id AND [UserId] = @UserId;";

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
                sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = updatingEvent.Status;
                sqlCommand.Parameters.AddWithValue("@EventDate", SqlDbType.DateTime).Value = updatingEvent.EventDate;

                SqlParameter contactId = new SqlParameter("ContactId", SqlDbType.Int);
                if (updatingEvent.ContactId == 0)
                    contactId.Value = DBNull.Value;
                else
                    contactId.Value = updatingEvent.ContactId;
                sqlCommand.Parameters.Add(contactId);

                SqlParameter eventEndDate = new SqlParameter("@EventEndDate", SqlDbType.DateTime);
                if (updatingEvent.EventEndDate == DateTime.MinValue)
                    eventEndDate.Value = DBNull.Value;
                else
                    eventEndDate.Value = updatingEvent.EventEndDate;
                sqlCommand.Parameters.Add(eventEndDate);

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
                MessageStatus.Message = ex.Message;
                MessageStatus.ErrorStatus = true;
            }
            finally
            {
                SqlConnection.Close();
            }

            return MessageStatus;
        }

        public MessageStatus DeleteEvent(RecurringEvent deletingEvent)
        {
            Query = "DELETE FROM RecurringEvents WHERE [Id] = @Id AND [UserId] = @UserId;";

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
