import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-assignment1',
  templateUrl: './assignment1.component.html',
  styleUrls: ['./assignment1.component.css']
})
export class Assignment1Component {
  input_temperature!: number;
  output_temperature!: number;
  selectedUnit!: string;

  convert(){
    if(this.selectedUnit=='1')
    this.output_temperature = (this.input_temperature * 9/5)+32;
  else
  this.output_temperature = (this.input_temperature -32) * 5/9;
  }


}
