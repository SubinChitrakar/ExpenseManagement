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
    class RecurringTransactionRepository : BaseRepository
    {
        //Constructor
        public RecurringTransactionRepository() : base() { }

        public List<RecurringTransaction> GetTransactions(int userId)
        {
            List<RecurringTransaction> recurringTransactionList = new List<RecurringTransaction>();
            Query = "SELECT RecurringTransactions.*, Contacts.ContactName FROM RecurringTransactions LEFT JOIN Contacts ON RecurringTransactions.ContactId = Contacts.ContactId WHERE RecurringTransactions.UserId = @UserId ORDER BY RecurringTransactions.TransactionDate DESC";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    RecurringTransaction recurringTransaction = new RecurringTransaction
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Amount = Convert.ToDouble(sqlDataReader["Amount"]),
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        TransactionDate = (DateTime)sqlDataReader["TransactionDate"],
                        Status = sqlDataReader["Status"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    };

                    if (sqlDataReader["ContactId"] == DBNull.Value)
                        recurringTransaction.ContactId = 0;
                    else
                        recurringTransaction.ContactId = (int)sqlDataReader["ContactId"];


                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        recurringTransaction.ContactName = "";
                    else
                        recurringTransaction.ContactName = sqlDataReader["ContactName"].ToString();

                    if (sqlDataReader["TransactionEndDate"] == DBNull.Value)
                        recurringTransaction.TransactionEndDate = DateTime.MinValue;
                    else
                        recurringTransaction.TransactionEndDate = (DateTime)sqlDataReader["TransactionEndDate"];

                    recurringTransactionList.Add(recurringTransaction);

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
            return recurringTransactionList;
        }

        public List<RecurringTransaction> GetExpenseTransactions(int userId)
        {
            List<RecurringTransaction> recurringTransactionList = new List<RecurringTransaction>();
            Query = "SELECT * FROM RecurringTransactions WHERE UserId = @UserId AND Type = @Type ORDER BY TransactionDate DESC";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = "Expense";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    RecurringTransaction recurringTransaction = new RecurringTransaction
                    {
                        Id = (int)sqlDataReader["Id"],
                        Name = sqlDataReader["Name"].ToString(),
                        Amount = Convert.ToDouble(sqlDataReader["Amount"]),
                        Type = sqlDataReader["Type"].ToString(),
                        Note = sqlDataReader["Note"].ToString(),
                        TransactionDate = (DateTime)sqlDataReader["TransactionDate"],
                        Status = sqlDataReader["Status"].ToString(),
                        UserId = (int)sqlDataReader["UserId"]
                    };
                    if (sqlDataReader["TransactionEndDate"] == DBNull.Value)
                        recurringTransaction.TransactionEndDate = DateTime.MinValue;
                    else
                        recurringTransaction.TransactionEndDate = (DateTime)sqlDataReader["TransactionEndDate"];

                    recurringTransactionList.Add(recurringTransaction);
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
            return recurringTransactionList;
        }

        public MessageStatus AddRecurringTransaction(RecurringTransaction recurringTransaction)
        {
            Query = "INSERT INTO RecurringTransactions([Name], [Amount], [Type], [Note], [TransactionDate], [ContactId], [Status], [TransactionEndDate], [UserId]) VALUES(@Name, @Amount, @Type, @Note, @TransactionDate, @ContactId, @Status, @TransactionEndDate, @UserId);";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = recurringTransaction.Name;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = recurringTransaction.Amount;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = recurringTransaction.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = recurringTransaction.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = recurringTransaction.Status;
                sqlCommand.Parameters.Add("@TransactionDate", SqlDbType.DateTime).Value = recurringTransaction.TransactionDate;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = recurringTransaction.UserId;

                SqlParameter ContactId = new SqlParameter("@ContactId", SqlDbType.Int);
                if (recurringTransaction.ContactId == 0) ContactId.Value = DBNull.Value;
                else ContactId.Value = recurringTransaction.ContactId;
                sqlCommand.Parameters.Add(ContactId);

                SqlParameter transactionEndDate = new SqlParameter("@TransactionEndDate", SqlDbType.DateTime);
                if (recurringTransaction.TransactionEndDate == DateTime.MinValue)
                    transactionEndDate.Value = DBNull.Value;
                else
                    transactionEndDate.Value = recurringTransaction.TransactionEndDate;
                sqlCommand.Parameters.Add(transactionEndDate);

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
        public MessageStatus UpdateRecurringTransaction(RecurringTransaction recurringTransaction)
        {
            Query = "UPDATE RecurringTransactions SET [Name] = @Name, [Amount] = @Amount, [Type] = @Type, [Note] = @Note, [TransactionDate] = @TransactionDate, [ContactId] = @ContactId, [Status] = @Status, [TransactionEndDate] = @TransactionEndDate WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = recurringTransaction.Id;
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = recurringTransaction.Name;
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Money).Value = recurringTransaction.Amount;
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = recurringTransaction.Type;
                sqlCommand.Parameters.Add("@Note", SqlDbType.VarChar).Value = recurringTransaction.Note;
                sqlCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = recurringTransaction.Status;
                sqlCommand.Parameters.AddWithValue("@TransactionDate", Convert.ToDateTime(recurringTransaction.TransactionDate));
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = recurringTransaction.UserId;

                SqlParameter ContactId = new SqlParameter("@ContactId", SqlDbType.Int);
                if (recurringTransaction.ContactId == 0) ContactId.Value = DBNull.Value;
                else ContactId.Value = recurringTransaction.ContactId;
                sqlCommand.Parameters.Add(ContactId);

                SqlParameter transactionEndDate = new SqlParameter("@TransactionEndDate", SqlDbType.DateTime);
                if (recurringTransaction.TransactionEndDate == DateTime.MinValue)
                    transactionEndDate.Value = DBNull.Value;
                else
                    transactionEndDate.Value = recurringTransaction.TransactionEndDate;
                sqlCommand.Parameters.Add(transactionEndDate);

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

        public MessageStatus DeleteRecurringTransaction(RecurringTransaction recurringTransaction)
        {
            Query = "DELETE FROM RecurringTransactions WHERE [Id] = @Id AND [UserId] = @UserId;";

            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = recurringTransaction.Id;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.Int).Value = recurringTransaction.UserId;

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
