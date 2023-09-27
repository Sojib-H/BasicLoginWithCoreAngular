import { Injectable } from '@angular/core';
import { Login } from '../Models/Login';
import { SessionDataModel } from '../Models/SessionDataModel';
import { CommonEndpointService } from './common-endpoint.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private commonEndpoint: CommonEndpointService) { }

  login(login: Login) {
    return this.commonEndpoint.PostNewEndpoint<SessionDataModel>(login, 'api/Login/Login');
  }
}
