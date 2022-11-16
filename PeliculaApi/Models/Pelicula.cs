﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeliculaApi.Models;

public class Pelicula
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string RutaImagen { get; set; }
    public string Descripcion { get; set; }
    public string Duracion { get; set; }
    public enum TipoClasificacion { Siete, Trece, Dieciseis, Dieciocho }
    public TipoClasificacion Clasificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    
    // Relacion foreing key
    public int CategoriaId { get; set; }
    
    [ForeignKey("CategoriaId")] 
    public Categoria Categoria { get; set; }
}