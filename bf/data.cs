using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bf
{
  public  class data
    {
      public string path = "D:\\test\\";
      public int buffer_size = 34;
      public int no_records = 0;
      

     public bool exists(string filename)
      {
          if (File.Exists(path + filename))

              return true;
          
          else
              return false;
              
      }
     public void create(string filename)
     {
         FileStream file = File.Create(path + filename);
         file.Close();
     }
     public void write_record(string filename,List<string> record_fields)
     {
         FileStream file = File.Open(path + filename, FileMode.Append);
         BinaryWriter bw = new BinaryWriter(file);
         
         string record="";

         for (int i = 0; i < record_fields.Count; i++)
         {
             
                 record += record_fields[i];
         }
         byte[] buffer = Encoding.UTF8.GetBytes(record);
         bw.Write(buffer,0,buffer.Length);
         bw.Close();
         file.Close();
         System.Windows.Forms.MessageBox.Show("Data inserted successfully");
         return;
     }
     public void read(string filename, List<string> record_fields,int record_index)
  {
        FileStream file=File.Open(path+filename,FileMode.Open);
          BinaryReader br=new BinaryReader(file, Encoding.UTF8);
          br.BaseStream.Seek(34*record_index, SeekOrigin.Begin);
          byte[] buffer = br.ReadBytes(buffer_size);
          record_fields.Clear();
          string temp = "";
          for (int i = 0; i < 15; i++)
          {
              
                 temp += (char)buffer[i];
          }
          record_fields.Add(temp);
          temp = "";
          for (int i = 15; i < 26; i++)
          {
              temp += (char)buffer[i];
          }
          record_fields.Add(temp);
              temp = "";
          for (int i = 26; i < 28; i++)
          {
              temp += (char)buffer[i];
          }
          record_fields.Add(temp);
         temp = "";
          for (int i = 28; i <34 ; i++)
          {
              temp += (char)buffer[i];
          }
          record_fields.Add(temp);
          temp = "";
          
          br.Close();
          file.Close();
      }
   public long numofrecords(string filename)
     {
         FileStream file = File.Open(path + filename, FileMode.Open);
         long num_records=file.Length/buffer_size;
         file.Close();
         return num_records;

     }
   public int get(string name, string filename, List<string> record_fields)
   {
       long x = numofrecords(filename);
       for (int i = 0; i < x; i++)
       {
           read(filename, record_fields, i);
           if (record_fields[0] == name)
           {
               return i;
           }
         
       }
       return -1;
       
   }

      public void modify(string filename, int record_index, List<string> record_fields)
      {
          FileStream file = File.Open(path + filename, FileMode.Open);
          BinaryWriter bw = new BinaryWriter(file, Encoding.UTF8);
          bw.BaseStream.Seek(buffer_size* record_index, SeekOrigin.Begin);
          byte[] buffer = new byte[buffer_size];
          string record="";
          for (int i = 0; i < record_fields.Count; i++)
          {     
              record+=record_fields[i];
              
          }
          for (int j = 0; j < record.Length; j++)
              {
                  buffer[j] += (byte)record[j];
              }

          bw.Write(buffer);
          file.Close();

      }
        
    } 
    
}
