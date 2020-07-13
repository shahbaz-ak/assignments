import { Component, OnInit } from '@angular/core';

import { Employee } from '../../models/employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
employees: Employee[];
  constructor() { }

  ngOnInit(): void {
    this.employees = [{
      eid: 'E001',
    ename: 'Shahbaz',
    desig: 'SE',
    joinDate: new Date(2010,10,20),
    salary: 2000
    },
    {
      eid: 'E002',
    ename: 'Ibrahim',
    desig: 'SE',
    joinDate: new Date(2010,7,23),
    salary: 3000
    }];
  }

}
