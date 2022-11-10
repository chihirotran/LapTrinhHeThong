/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package serversocket;

import java.io.*;
import java.net.*;
import java.util.ArrayList;
import java.util.Scanner;
import serversocket.cauhoitracnghiem;
import java.util.List;

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
        try {
            ServerSocket svk = new ServerSocket(1501);
            System.out.println("Cho ket Noi");
            Socket s = svk.accept();
            String tin = "";
            System.out.println("Co 1 thiet bi ket noi den server: " + s.getInetAddress().getHostAddress());
            List<cauhoitracnghiem> l1 = new ArrayList<cauhoitracnghiem>();
            l1.add(new cauhoitracnghiem("c1", "a", "b", "c", "d", "a"));
            l1.add(new cauhoitracnghiem("c2", "a", "b", "c", "d", "a"));
            l1.add(new cauhoitracnghiem("c3", "a", "b", "c", "d", "c"));
            l1.add(new cauhoitracnghiem("c4", "a", "b", "c", "d", "b"));
            l1.add(new cauhoitracnghiem("c5", "a", "b", "c", "d", "d"));
            l1.add(new cauhoitracnghiem("c6", "a", "b", "c", "d", "d"));
            PrintWriter out = new PrintWriter(new OutputStreamWriter(s.getOutputStream()));
            BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));

            int dem = 0;
            String sl = "" + l1.size();
            out.println(sl);
            out.flush();
            System.out.println("" + sl);
            for (int i = 0; i < l1.size(); i++) {
                tin = l1.get(i).getCauHoi();
                String ctl = l1.get(i).toString1();
                out.println(tin + "\n" + ctl);
                out.flush();
                String nhan = in.readLine();
                if (nhan.equals(l1.get(i).getDapAnDung()) == true) {
                    dem++;
                }

            }
            String a = dem + "/" + sl;
            out.println(a);
            out.flush();
            in.close();
            out.close();
            s.close();
            svk.close();

        } catch (Exception e) {
            System.out.println("Loi: " + e.getMessage());
        }
    }
}
