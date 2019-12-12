using ExpenseManagement.Model;
using ExpenseManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagement.Repository
{
    class NormalTransactionRepository : BaseRepository
    {
        //Constructor
        public NormalTransactionRepository() : base() { }

        public List<Transaction> GetTransactions(int userId)
        {
            List<Transaction> normalTransactionList = new List<Transaction>();
            Query = "SELECT NormalTransactions.*, Contacts.ContactName FROM NormalTransactions LEFT JOIN Contacts ON NormalTransactions.ContactId = Contacts.ContactId WHERE NormalTransactions.UserId = @UserId ORDER BY NormalTransactions.TransactionDate DESC";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Transaction normalTransaction = new Transaction
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Amount = Convert.ToDouble(sqlDataReader["Amount"]),
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        TransactionDate = (DateTime)sqlDataReader["TransactionDate"],
                        UserId = (int)sqlDataReader["UserId"]
                    };

                    if (sqlDataReader["ContactId"] == DBNull.Value)
                        normalTransaction.ContactId = 0;
                    else
                        normalTransaction.ContactId = (int)sqlDataReader["ContactId"];


                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        normalTransaction.ContactName = "";
                    else
                        normalTransaction.ContactName = sqlDataReader["ContactName"].ToString();

                    normalTransactionList.Add(normalTransaction);

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

        public MessageStatus AddNormalTransaction(Transaction normalTransaction)
        {
            Query = "INSERT INTO NormalTransactions([Name], [Amount], [Type], [Note], [TransactionDate], [ContactId], [UserId]) VALUES(@Name, @Amount, @Type, @Note, @TransactionDate, @ContactId, @UserId);";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = normalTransaction.Name;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = normalTransaction.Amount;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = normalTransaction.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = normalTransaction.Note;
                sqlCommand.Parameters.Add("@TransactionDate", SqlDbType.DateTime).Value = normalTransaction.TransactionDate;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = normalTransaction.UserId;

                SqlParameter ContactId = new SqlParameter("@ContactId", SqlDbType.Int);
                if (normalTransaction.ContactId == 0) ContactId.Value = DBNull.Value;
                else ContactId.Value = normalTransaction.ContactId;
                sqlCommand.Parameters.Add(ContactId);

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
        public MessageStatus UpdateNormalTransaction(Transaction normalTransaction)
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
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = normalTransaction.UserId;

                SqlParameter ContactId = new SqlParameter("@ContactId", SqlDbType.Int);
                if (normalTransaction.ContactId == 0) ContactId.Value = DBNull.Value;
                else ContactId.Value = normalTransaction.ContactId;
                sqlCommand.Parameters.Add(ContactId);

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

        public MessageStatus DeleteNormalTransaction(Transaction normalTransaction)
        {
            Query = "DELETE FROM NormalTransactions WHERE [Id] = @Id AND [UserId] = @UserId;";

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
