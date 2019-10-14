import { CadastroService } from "./../cadastro.service";
import { CadastroDataService } from "./../cadastro-data.service";
import { Component, OnInit } from "@angular/core";
import { Cadastro } from "../cadastro";

@Component({
  selector: "app-edit",
  templateUrl: "./edit.component.html",
  styleUrls: ["./edit.component.css"]
})
export class EditComponent implements OnInit {
  cadastro: Cadastro;
  key: string = "";

  constructor(
    private _cadastroService: CadastroService,
    private _cadastroDataService: CadastroDataService
  ) {}

  ngOnInit() {
    this.cadastro = new Cadastro();
    this._cadastroDataService.cadastroAtual.subscribe(data => {
      if (data.cadastro && data.key) {
        this.cadastro = new Cadastro();
        this.cadastro.nome = data.cadastro.nome;
        this.cadastro.contato = data.cadastro.contato;
        this.key = data.key;
      }
    });
  }

  onSubmit() {
    if (this.key) {
      this._cadastroService.update(this.cadastro, this.key);
    } else {
      this._cadastroService.insert(this.cadastro);
    }

    this.cadastro = new Cadastro();
    this.key = null;
  }
}
