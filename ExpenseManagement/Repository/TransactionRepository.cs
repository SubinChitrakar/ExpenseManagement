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
    class TransactionRepository : BaseRepository
    {
        //Constructor
        public TransactionRepository() : base() { }

        public List<NormalTransaction> GetTransactions(int userId)
        {
            List<NormalTransaction> normalTransactionList = new List<NormalTransaction>();
            Query = "SELECT NormalTransactions.*, Contacts.Name FROM NormalTransactions LEFT JOIN Contacts ON NormalTransactions.ContactId = Contacts.Id WHERE [NormalTransactions.UserId] = @UserId";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    normalTransactionList.Add(new NormalTransaction
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Amount = (double)sqlDataReader["Amount"],
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        TransactionDate = (DateTime)sqlDataReader["TransactionDate"],
                        ContactId = (int)sqlDataReader["ContactId"],
                        ContactName = sqlDataReader["ContactName"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    });
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
            return normalTransactionList;
        }

        public List<NormalTransaction> GetTransactionFromDate(DateTime date, int userId)
        {
            List<NormalTransaction> normalTransactionList = new List<NormalTransaction>();
            Query = "SELECT NormalTransactions.*, Contacts.Name FROM NormalTransactions LEFT JOIN Contacts ON NormalTransactions.ContactId = Contacts.Id WHERE [NormalTransactions.UserId] = @UserId AND [NormalTransactions.TransactionDate] LIKE @TransactionDate%";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                sqlCommand.Parameters.AddWithValue("@TransactionDate", Convert.ToDateTime(date.Date));
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    normalTransactionList.Add(new NormalTransaction
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Amount = (double)sqlDataReader["Amount"],
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        TransactionDate = (DateTime)sqlDataReader["TransactionDate"],
                        ContactId = (int)sqlDataReader["ContactId"],
                        ContactName = sqlDataReader["ContactName"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    });
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
            return normalTransactionList;
        }

        public MessageStatus AddNormalTransaction(NormalTransaction normalTransaction)
        {
            Query = "INSERT INTO Transactions([Name], [Amount], [Type], [Note], [TransactionDate], [ContactId], [UserId]) VALUES(@Name, @Amount, @Type, @Note, @TransactionDate, @ContactId, @UserId);";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = normalTransaction.Name;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = normalTransaction.Amount;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = normalTransaction.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = normalTransaction.Note;
                sqlCommand.Parameters.AddWithValue("@TransactionDate", Convert.ToDateTime(normalTransaction.TransactionDate));
                sqlCommand.Parameters.Add("@ContactId", SqlDbType.Int).Value = normalTransaction.ContactId;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = normalTransaction.UserId;

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Transaction Added Successfully!!";
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
        public MessageStatus UpdateNormalTransaction(NormalTransaction normalTransaction)
        {
            Query = "UPDATE NormalTransactions SET [Name] = @Name, [Amount] = @Amount, [Type] = @Type, [Note] = @Note, [TransactionDate] = @TransactionDate, [ContactId] = @ContactId WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = normalTransaction.Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = normalTransaction.Name;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = normalTransaction.Amount;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = normalTransaction.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = normalTransaction.Note;
                sqlCommand.Parameters.AddWithValue("@TransactionDate", Convert.ToDateTime(normalTransaction.TransactionDate));
                sqlCommand.Parameters.Add("@ContactId", SqlDbType.Int).Value = normalTransaction.ContactId;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = normalTransaction.UserId;
               

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Transaction Updated Successfully!!";
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

        public MessageStatus DeleteNormalTransaction(NormalTransaction normalTransaction)
        {
            Query = "DELETE FROM Transactions WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = normalTransaction.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = normalTransaction.UserId;

                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageStatus.Message = "Transaction Deleted Successfully!!";
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
