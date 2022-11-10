/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package mythread;

/**
 *
 * @author chihi
 */
public class myThr2 implements Runnable {
    public void start(){
        Thread t = new Thread(this);
        t.start();
    }
    @Override
    public void run(){
//        System.out.println("This is my Thread");
         
            try {
        while (Mythread.s.toLowerCase().equals("thoat")==false)
        {
            if(Mythread.check == true){
                System.out.println("s= " + Mythread.s);
                Mythread.check = false;
            }
            Thread.sleep(1000);
        }
    } catch (Exception e) {
        System.out.println("Loi: "+e.getMessage());
    }
    }
}
