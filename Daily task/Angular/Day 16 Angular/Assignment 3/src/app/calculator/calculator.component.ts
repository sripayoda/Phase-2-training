import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  expression='';
  buttonclick(inp: string){
    this.expression+=inp;
  }
  equal()
  {
    this.expression=eval(this.expression);
  }

  clr()
  {
    this.expression=''
  }
  bck()
  {
    this.expression=this.expression.slice(0,-1);
  }


}
