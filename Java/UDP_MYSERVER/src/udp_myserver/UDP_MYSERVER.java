/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package udp_myserver;

import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;



/**
 *
 * @author chihi
 */
public class UDP_MYSERVER {

    /**
     * @param args the command line arguments
     */
    public static boolean ktraSoHH(int a)
        {
            int sum = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                    //tổng các ước số của a
                    sum += i;
            }
            if (sum == a) return true;
            return false;
        }
    public static void main(String[] args) {
        // TODO code application logic here
        try{
            String tinend="thoat";
            String tinnhan="";
            DatagramSocket serverSocket= new DatagramSocket(1501);
            while (tinend.equals(tinnhan)==false) {                
            byte[] nhandata = new byte[1024] ; byte[] guidata = new byte[1024];
            
            System.out.println("chowf 1 goi tin tu client");
            DatagramPacket nhanpacket = new DatagramPacket(nhandata, nhandata.length);
            serverSocket.receive(nhanpacket);
            tinnhan = new String(nhanpacket.getData(),nhanpacket.getOffset(),nhanpacket.getLength());    
            System.out.println("<client>: "+tinnhan+"*"+tinend);
            int a= Integer.parseInt(tinnhan);
            InetAddress ipclient = nhanpacket.getAddress();
            int portclient =nhanpacket.getPort();
            if(ktraSoHH(a)==true ){
                String b ="la so hoan hao";
                guidata=b.getBytes();
                DatagramPacket guiPacket = new DatagramPacket(guidata,guidata.length,ipclient , portclient);
                serverSocket.send(guiPacket);
            }
            else{
                String b ="khong phai so hoan hao";
                guidata=b.getBytes();
                DatagramPacket guiPacket = new DatagramPacket(guidata,guidata.length,ipclient , portclient);
                serverSocket.send(guiPacket);
            }
            if (tinend.equals(tinnhan)==true) {
                serverSocket.close();
            } else {
//            String send = scanner.nextLine();
//            guidata=send.getBytes();
//            
//            DatagramPacket guiPacket = new DatagramPacket(guidata,guidata.length,ipclient , portclient);
//            serverSocket.send(guiPacket);
            
            }
            
            
//            byte[] nhandata = new byte[1024] ; byte[] guidata = new byte[1024];
//            DatagramSocket serverSocket= new DatagramSocket(1501);
//            System.out.println("chowf 1 goi tin tu client");
//            DatagramPacket nhanpacket = new DatagramPacket(nhandata, nhandata.length);
//            serverSocket.receive(nhanpacket);
//            String tinnhan = new String (nhanpacket.getData());
//            System.out.println("<client>: "+tinnhan);
//            String send = tinnhan.toUpperCase();
//            guidata=send.getBytes();
//            InetAddress ipclient = nhanpacket.getAddress();
//            int portclient =nhanpacket.getPort();
//            DatagramPacket guiPacket = new DatagramPacket(guidata,guidata.length,ipclient , portclient);
//            serverSocket.send(guiPacket);
//            serverSocket.close();
            }}
        catch(Exception e){
            System.out.println("Loi: " + e.getMessage());
        }
    }
    
}
