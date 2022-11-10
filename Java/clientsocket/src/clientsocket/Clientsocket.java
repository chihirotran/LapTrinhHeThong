/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package clientsocket;

import java.io.*;
import java.net.*;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author chihi
 */
public class Clientsocket {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            Socket s = new Socket("localhost", 1501);
            System.out.println("Ket Noi Thanh Cong Den Server");
            PrintWriter out = new PrintWriter(new OutputStreamWriter(s.getOutputStream()));
            BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
            String tin = "";
            String sl1 =in.readLine();
            int sl = Integer.parseInt(sl1);
            System.out.println(""+sl);
            for (int i = 0; i < sl; i++) {
                String nhanString;
                nhanString = in.readLine();
                System.out.println("<Server>:   " + nhanString);
                String nhanString1;
                nhanString1 = in.readLine();
                System.out.println("<Server>:   " + nhanString1);
                Scanner scanner = new Scanner(System.in);
                tin = scanner.nextLine();
                out.println(tin);
                out.flush();
                if (tin.equals("thoat") == false) {

                } else {
                    break;
                }
            }
            String nhanString;
            nhanString = in.readLine();
            System.out.println("<Server>:   " + nhanString);
            in.close();
            out.close();
            s.close();

        } catch (IOException ex) {
            Logger.getLogger(Clientsocket.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
