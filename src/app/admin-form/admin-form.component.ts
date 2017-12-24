import { Component, OnInit } from '@angular/core';
import { Admin } from './admin';
@Component({
  selector: 'admin-form',
  templateUrl: './admin-form.component.html',
  styleUrls: ['./admin-form.component.css'],
})
export class AdminFormComponent implements OnInit {
public admin: Admin; // our Model
  constructor() { }

  ngOnInit() {
    this.admin = {
      Name: 'Nasser M. Tabook',
      Password: '',
      Email: 'abc@abc.com',
      Phone: 0
    };
  }

  save(mode: Admin, isValid: boolean)
  {
          // check if model is valid
        // if valid, call API to save customer
        console.log(mode, isValid);
  }
}
