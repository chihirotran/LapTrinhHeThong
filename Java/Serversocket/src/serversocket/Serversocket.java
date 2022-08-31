/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package serversocket;
import java.io.*;
import java.net.*;
/**
 *
 * @author chihi
 */
public class Serversocket {

    /**
     * @param args the command line arguments
     * @throws java.io.IOException
     */
    public static void main(String[] args) throws IOException {
        try ( // TODO code application logic here
            ServerSocket svk = new ServerSocket(1501)) {
            System.out.println("Cho ket Noi");
            Socket s = svk.accept();
            System.out.println("Co 1 thiet bi ket noi den server: "+s.getInetAddress().getHostAddress());
            PrintWriter out  = new PrintWriter(new OutputStreamWriter(s.getOutputStream()));
            BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
            String nhan = in.readLine();
            System.out.println("<client>:  "+ nhan);
            String tin = nhan.toUpperCase();
            out.println(tin);
            out.flush();
            in.close();
            out.close();
            svk.close();
        }
    }
    
}
