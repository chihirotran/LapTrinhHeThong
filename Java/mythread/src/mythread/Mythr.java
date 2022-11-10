/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package mythread;

import java.util.Scanner;

/**
 *
 * @author chihi
 */
public class Mythr extends Thread {
    @Override
    public void run(){
//        System.out.println("This is my Thread");
do {            
            Scanner sc = new Scanner(System.in);
            Mythread.s = sc.nextLine();
            Mythread.check = false;
                    
        } while (Mythread.s.toLowerCase().equals("thoat")==false);
    }
}
