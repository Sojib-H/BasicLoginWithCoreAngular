import { Injectable } from '@angular/core';
import { EmployeeInfo } from '../Models/EmployeeInfo';
import { CommonEndpointService } from './common-endpoint.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private commonEndpoint: CommonEndpointService) { }

  GetAllEmployee() {
    return this.commonEndpoint.getAllEndpoint<EmployeeInfo[]>('api/EmployeeInfo/GetAllEmployee');
  }
}
