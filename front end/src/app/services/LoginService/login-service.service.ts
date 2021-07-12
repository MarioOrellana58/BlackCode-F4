import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs/internal/observable/of';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  constructor(private http: HttpClient) { }

  public sendLoginData(data): Observable<any>{

    let options =  new HttpParams();
    options = options.append('username', data.username);
    options = options.append('password', data.password);

    return this.http.get(environment.sendLoginData, { params: options }).pipe(
      map(res => {
        return res;
      }),
      catchError(err => of(err))
    )
  }
}
