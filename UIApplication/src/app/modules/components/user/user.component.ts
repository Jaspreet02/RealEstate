import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from '../../../shared/models/user';
import { UserService } from '../../../core/services/user.service';
import { ConfirmationService, MessageService } from 'primeng/api';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'],
  providers: [ConfirmationService,MessageService]
})

export class UserComponent implements OnInit {

  Users: User[];

  _total: number;

  pageNumber: number = 0;

  pageSize: number = 5;

  sortF: string = 'CreatedAt';

  sortO: string;

  selectedUser: User;

  loading: boolean;

  constructor(private router: Router, private confirmationService: ConfirmationService, private userService: UserService,private messageService: MessageService) { }

  ngOnInit() {
    //this.getUsers();
  }

  showDialogToAdd() {
    this.router.navigate(['/' + localStorage.getItem('role') + '/user']);
  }

  onSelect(): void {
    this.router.navigate(['/' + localStorage.getItem('role') + '/user/' + this.selectedUser.id]);
  }

  getUsers(): void {
    this.loading = true;
    this.userService
      .getUsers(this.pageNumber, this.pageSize, this.sortF, this.sortO == '1' ? 'asc' : 'desc')
      .subscribe(x => (this.Users = x.result, this._total = x.count, this.loading = false));
  }

  onRowEditInit(user: User) {
    this.selectedUser = this.Users.find(x=> x.id == user.id);
}

onRowEditSave(user: User) {
    if (user.id != null) {
        this.selectedUser = null;
        this.messageService.add({severity:'success', summary: 'Success', detail:'Car is updated'});
    }
    else {
        this.messageService.add({severity:'error', summary: 'Error', detail:'Year is required'});
    }
}

onRowEditCancel(car: User, index: number) {
     this.selectedUser = null;
}

  paginate(event) {
    console.log(event);
    this.pageNumber = event.first;
    this.pageSize = event.rows;
    this.getUsers();
    // event.first = Index of the first record
    // event.rows = Number of rows to display in new page
    // event.page = Index of the new page
    // event.pageCount = Total number of pages
  }

  changeSort(event) {
    if (!event.order) {
      this.sortF = 'CreatedAt';
      this.sortO = '-1';
    } else {
      this.sortF = event.field;
      this.sortO = event.order;
    }
    this.getUsers();
  }

  delete(userId, index) {
    this.confirmationService.confirm({
      message: 'Do you want to delete this record?',
      header: 'Delete',
      icon: 'fa fa-info-circle',
      accept: () => {
        this.userService.deleteUser(userId).subscribe(x =>
          this.Users = this.Users.filter((val, i) => i != index)
        );
      },
      reject: () => {
      }
    });
  }
}
