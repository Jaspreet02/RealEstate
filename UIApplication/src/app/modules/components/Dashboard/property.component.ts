import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-property',
  templateUrl: './property.component.html',
  styleUrls: ['./property.component.css']
})

export class PropertyComponent implements OnInit {

  // navbarOpen: boolean = false;

  images: any[];

  constructor(private router: Router) {}

  ngOnInit() {  this.images = [];
    this.images.push({source:'../../../assets/images/landing-page.png', alt:'Description for Image 1', title:'Title 1'});
    } 

    toggleNavbar(){
      // this.navbarOpen = !this.navbarOpen;
    }
}
