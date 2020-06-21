import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/map';
import { City } from '../../shared/models/city';


const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()

export class CityService {

  private Url = 'http://localhost:8004/api/City';  // URL to web api

  constructor( private http: HttpClient) {}

  getCities(pageNumber: number, pageSize: number,sortField: string, sortOrder: string): Observable<PagedResponse<City>> {
   // return of(Users);
   return this.http.get<PagedResponse<City>>(this.Url + '/' + pageNumber + '/' + pageSize + '/' + sortField + '/' + sortOrder);
  // return this.http.get<PagedResponse<Property>>(this.Url );
  }

    /** POST: add a new user to the server */
    getCity (id: string): Observable<City> {
      return this.http.get<City>(this.Url + '/' + id);
    }

  /** POST: add a new user to the server */
  addCity (user: City): Observable<City> {
    const url = `${this.Url}`;
    return this.http.post<City>(url, user, httpOptions);
  }

  /** DELETE: delete the user from the server */
  deleteCity (user: City | string): Observable<City> {
    const id = typeof user === 'string' ? user : user.cityId;
    const url = `${this.Url}/Delete/${id}`;

    return this.http.delete<City>(url, httpOptions);
  }

  /** PUT: update the user on the server */
  updateUser (user: City): Observable<any> {
    const url = `${this.Url}/Put/${user.cityId}`;
    return this.http.put(url, user, httpOptions);
  }
}

export interface PagedResponse<T> {
  count: number;
  result: T[];
}
