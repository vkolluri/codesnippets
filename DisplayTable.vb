bcp "select * from tempdb..vw_bcpMasterSysobjects
          order by crdate desc, crtime desc"
       queryout c:\bcp\sysobjects.txt -c -t, -T -S
