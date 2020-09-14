import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { UserService } from '../_services/user.service';
import { User } from '../_models/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  user: User;
  searchForm: FormGroup;

  constructor(private userService: UserService, private alertify: AlertifyService,
      private fb: FormBuilder, private router: Router) { }

  ngOnInit() {
    this.searchForm = this.fb.group({
      username: ['']
    });
  }

  searchUser() {
    console.log(this.searchForm.value.username);
    this.userService.getUserByUsername(this.searchForm.value.username).subscribe((user: User) => {
      this.user = user;
      this.router.navigate(['members/' + user.id]);
    }, error => {
        this.alertify.error(error);
    });
  }

}
