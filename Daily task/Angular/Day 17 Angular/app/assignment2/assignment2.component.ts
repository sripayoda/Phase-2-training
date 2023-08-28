import { Component } from '@angular/core';

@Component({
  selector: 'app-assignment2',
  templateUrl: './assignment2.component.html',
  styleUrls: ['./assignment2.component.css']
})
export class Assignment2Component {
  purchasePrice!: number;
  downPayment!: number;
  repaymentTime!: number;
  interestRate!: number;
  monthlyPayment: number | null = null;

  calculateMortgage() {
    const loanAmount = this.purchasePrice - this.downPayment;
    const monthlyInterest = (this.interestRate / 100) / 12;
    const numberOfPayments = this.repaymentTime * 12;
    const monthlyPayment = (loanAmount * monthlyInterest) / (1 - Math.pow(1 + monthlyInterest, -numberOfPayments));
    this.monthlyPayment = isNaN(monthlyPayment) ? null : monthlyPayment;
  }

}
