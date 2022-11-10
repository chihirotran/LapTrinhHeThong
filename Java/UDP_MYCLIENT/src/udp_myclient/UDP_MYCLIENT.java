/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package udp_myclient;

import com.sun.nio.sctp.SendFailedNotification;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.net.SocketException;
import java.net.UnknownHostException;
import java.util.Scanner;

/**
 *
 * @author chihi
 */
public class UDP_MYCLIENT {

    /**
     * @param args the command line arguments
     */
    
    public static void main(String[] args) throws UnknownHostException, SocketException, IOException {
        // TODO code application logic here
        try {
            String Send="";
            DatagramSocket clientSocket = new DatagramSocket(2002);
            while(Send.equals("thoat")==false) {
                byte[] nhandata = new byte[1024];
                byte[] guidata = new byte[1024];
                
                Scanner scanner = new Scanner(System.in);
                
                Send = scanner.nextLine();
                guidata = Send.getBytes();
                InetAddress ipserver = InetAddress.getByName("localhost");
                int portSercver = 1501;
                DatagramPacket guiPacket = new DatagramPacket(guidata, guidata.length, ipserver, portSercver);
                clientSocket.send(guiPacket);
                System.out.println("goi tin da duoc gui");
                if (Send.equals("thoat")==true) {
                     clientSocket.close();
                } else {
                DatagramPacket nhanPacket = new DatagramPacket(nhandata, nhandata.length);
                clientSocket.receive(nhanPacket);
                String tinnhan = new String(nhanPacket.getData());
                System.out.println("<server>: " + tinnhan);
                }
                
                
            } 
        }

//         byte[] nhandata = new byte[1024] ; byte[] guidata = new byte[1024];
//         DatagramSocket clientSocket= new DatagramSocket(2002);
//         String Send = "hello";
//         guidata = Send.getBytes();
//         InetAddress ipserver = InetAddress.getByName("localhost");
//         int portSercver= 1501;
//         DatagramPacket guiPacket = new DatagramPacket(guidata,guidata.length, ipserver, portSercver);
//         clientSocket.send(guiPacket);
//         System.out.println("goi tin da duoc gui");
//         DatagramPacket nhanPacket = new DatagramPacket(nhandata, nhandata.length);
//         clientSocket.receive(nhanPacket);
//         String tinnhan = new String(nhanPacket.getData());
//         System.out.println("<server>: "+tinnhan);
//            clientSocket.close();

         catch (Exception e) {
            System.out.println("Loi: " + e.getMessage());
        }

    }

}
