using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO; 

namespace Interview.domain
{
    public class SqlHelper
    {
        SqlConnection cn; 
        SqlCommand cmd;
        SqlDataAdapter sda; 
        DataSet ds; 
        static String conStr = @"Data Source=(LocalDB)\v11.0;                              
                                 AttachDbFilename=
                                 E:\VisualStudioProjects\InterviewSkillsTest\Interview.domain\InterviewDatabase.mdf;                        
                                 Integrated Security=True";
        static String path = @"G:\errorLog.txt";


        public int DML(Description obj)
        {
            try
            {
                cn = new SqlConnection(conStr);
                cn.Open();

                String ins_stmt = "insert into Description values(@desc,@topicid)";
                cmd = new SqlCommand(ins_stmt, cn);
                cmd.Parameters.AddWithValue("@desc", obj.description);
                cmd.Parameters.AddWithValue("@topicid", obj.Topic.topicid);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        //for  INSERT | UPDATE | DELETE statement 
        public int DML(String SqlStatement) 
{             
 try            
 {                 
cn = new SqlConnection(conStr);              
     cn.Open();                
 cmd = new SqlCommand(SqlStatement, cn);           
     int status = cmd.ExecuteNonQuery();               
     cn.Close();              
   return status;         
    }           
  catch (SqlException se)       
      {                
 if (!File.Exists(path))    
             {                 
    StreamWriter sw = File.CreateText(path);              
 }                
 using (StreamWriter sw = File.AppendText(path))             
 {         
            sw.WriteLine("Date : " + System.DateTime.Now + " SQL Error Number: " + se.Number + " and Message : " + se.Message);          
 }              
      return -1;       
      }            
 catch (Exception ex) 
{               
  if (!File.Exists(path))     
            {           
          StreamWriter sw = File.CreateText(path);    
  }               
  using (StreamWriter sw = File.AppendText(path))       
  {         
            sw.WriteLine("Date : " + System.DateTime.Now + " Error Message: " + ex.Message);         
        }         
        return -1;   
          }        
     finally          
   {                 
cmd.Dispose();          
       cn.Dispose();   
          }       
  }        
  //for SELECT statement   

      public DataTable GetData(String SqlStatement) {          
   try   
          {     
            cn = new SqlConnection(conStr);              
       cn.Open();         
        sda = new SqlDataAdapter(SqlStatement, cn);     
       ds = new DataSet();             
       sda.Fill(ds);                
 if (ds.Tables[0].Rows.Count != 0 && ds != null)   
     return ds.Tables[0];                
       return null;    

         } 

            catch (SqlException se)      
   {              
                if (!File.Exists(path))
   {                   
                    StreamWriter sw = File.CreateText(path);        
         }                
 using (StreamWriter sw = File.AppendText(path))
 {             
        sw.WriteLine("Date : " + System.DateTime.Now+ " SQL Error Number: " + se.Number+ " and Message : " + se.Message);                 
}             
    return null;     
        }           
  catch (Exception ex)       
      {              
   if (!File.Exists(path))   
              {             
        StreamWriter sw = File.CreateText(path);            
   }            

     using (StreamWriter sw = File.AppendText(path))   
     {           
          sw.WriteLine("Date : " + System.DateTime.Now+ ". Error Message: " + ex.Message);   
              }              
   return null;            

 }            
   finally     
        {                
 sda.Dispose();            
     ds.Dispose();    
             cn.Dispose();   
          }     
      }      
        ////for Aggregate functions     
        public int GetRowCount(String SqlStatement)
    {       
            try   
            {               
        cn = new SqlConnection(conStr);           
        cn.Open();             
        cmd = new SqlCommand(SqlStatement, cn);  
        int status =(int) cmd.ExecuteScalar();    
        cn.Close();         
        return status;        
    }             catch (SqlException se)      
    {  
        if (!File.Exists(path))     
    {      
            StreamWriter sw = File.CreateText(path);          
    }      
        using (StreamWriter sw = File.AppendText(path))       
    {     
            sw.WriteLine("Date : " + System.DateTime.Now + " SQL Error Number: " + se.Number + " and Message : " + se.Message);          
    }       
        return -1;           
    }       
            catch (Exception ex)     
    {       
                if (!File.Exists(path))      
    {
                    StreamWriter sw = File.CreateText(path);              
    }
                using (StreamWriter sw = File.AppendText(path))           
    {         
                    sw.WriteLine("Date : " + System.DateTime.Now  + " Error Message: " + ex.Message);  
    }          
                return -1;         
    }          
            finally             {   
        cmd.Dispose();      
        cn.Dispose();       
    }       
        } 
 
    } } 