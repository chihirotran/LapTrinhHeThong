/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package mythread;

/**
 *
 * @author chihi
 */
public class Mythread {
    
    /**
     * @param args the command line arguments
     */
    public static String s="";
    public static boolean check= false;
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("This is main Thread");
        myThr2 t = new myThr2();
        Mythr t1 = new Mythr();
        t1.start();
        t.start();
    }
    
}
