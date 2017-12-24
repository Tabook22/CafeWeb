import { Component, OnInit } from '@angular/core';
import { AdminService } from '../admin.service';
import { Http  } from '@angular/http';
@Component({
  selector: 'admin-list',
  templateUrl: './admin-list.component.html',
  styleUrls: ['./admin-list.component.css']
})
export class AdminListComponent implements OnInit {
adminLst = [];
value = [];
  constructor(private _adminService: AdminService, private http: Http) { }

  ngOnInit() {
   this._adminService.getAdminLst()
   .subscribe(resAdminData => this.adminLst = resAdminData);
   // here we have an instance of AdminService and with that are going to call the getAdminLst(), the getAdminLst method
   // is going to return observalbe and as we know that observer don't send data unless we subscribe to it 
   // the subscribe method takes an arrow method, and in the input side we have resAdminData and in the outpus side
   // we have our adminlist array, which will get filled with data we susbscribed to it
  }
  getValues() {
    this.http.get("http://localhost:5000/api/admin").subscribe
                 ( response => this.value = response.json());
  }
}
