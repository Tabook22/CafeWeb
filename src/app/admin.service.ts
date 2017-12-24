// tslint:disable-next-line:eofline
import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';
@Injectable()
export class AdminService {
    private _url= "http://localhost:5000/api/admin";
    constructor(private _http: Http) {}
    getAdminLst() {
       return this._http.get(this._url)
       .map((response: Response) => response.json());
    }
}
