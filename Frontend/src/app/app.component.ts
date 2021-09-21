import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Frontend';
  usuarios: any[] = [];
  constructor(private httpClient: HttpClient) {}

  buscarUsuarios() {
    this.httpClient
      .get('http://localhost:5000/api/Usuarios/GetAllUsuarios')
      .subscribe((data: any) => {
        this.usuarios = data;
      });
  }
}
