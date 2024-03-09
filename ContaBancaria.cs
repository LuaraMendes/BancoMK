using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContaBancaria

{
    /* 
    CLASSE CONTA BANCARIA
    - numero da conta, nome do titular e saldo
    - metodo de funcao de receber deposito
    - metodo de funcao de debitar dinheiro da conta
    - funcao para consultar saldo
    - funcao para consultar o titular da conta
    */
    public string holderName;
    public int accountNumber;
    public int balance;

    public ContaBancaria(string _holderName, int _accountNumber, int _balance)
    {
        holderName = _holderName;
        accountNumber = _accountNumber;
        balance = _balance; 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
