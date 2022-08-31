/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package clientsocket;

import java.io.*;
import java.net.*;
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
            String tin = "hello";
            out.println(tin);
            out.flush();
            String nhanString;
            nhanString = in.readLine();
            System.out.println("<Server>:   " + nhanString);
            out.close();
            in.close();
            s.close();
        } catch (Exception ex) {
            Logger.getLogger(Clientsocket.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
