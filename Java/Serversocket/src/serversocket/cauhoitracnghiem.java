/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package serversocket;

/**
 *
 * @author chihi
 */
public class cauhoitracnghiem {
    private String CauHoi;
    private String DapAnA;
    private String DapAnB;
    
    private String DapAnC;
    private String DapAnD;
    private String DapAnDung;

    public cauhoitracnghiem(String CauHoi, String DapAnA, String DapAnB, String DapAnC, String DapAnD, String DapAnDung) {
        this.CauHoi = CauHoi;
        this.DapAnA = DapAnA;
        this.DapAnB = DapAnB;
        this.DapAnC = DapAnC;
        this.DapAnD = DapAnD;
        this.DapAnDung = DapAnDung;
    }

    public cauhoitracnghiem() {
    }

    public String getCauHoi() {
        return CauHoi;
    }

    public String getDapAnA() {
        return DapAnA;
    }

    public String getDapAnB() {
        return DapAnB;
    }

    public String getDapAnC() {
        return DapAnC;
    }

    public String getDapAnD() {
        return DapAnD;
    }

    public String getDapAnDung() {
        return DapAnDung;
    }
    public String toString1(){
        return (DapAnA+"\t"+DapAnB+"\t"+DapAnC+"\t"+DapAnD);
    }
}
