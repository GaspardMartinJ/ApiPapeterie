using ApiPapeterie.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiPapeterie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {

        private static List<Produit> _produits = new();

        private readonly ILogger<ProduitController> _logger;

        public ProduitController(ILogger<ProduitController> logger)
        {
            _logger = logger;
            _produits = GenerateProduits();
        }

        [HttpGet(Name = "GetProduit")]
        public IEnumerable<Produit> Get()
        {
            return _produits;
        }

        [HttpGet("{id}", Name = "GetProduitById")]
        public ActionResult<Produit> GetById(int id)
        {
            Produit? produit = _produits.Find(p => p.id == id);

            if (produit == null)
            {
                return NotFound(); // Returns a 404 Not Found response
            }

            return produit;
        }

        [HttpPost(Name = "AddProduit")]
        public void Post(Produit produit)
        {
            _produits.Add(produit);
        }

        private List<Produit> GenerateProduits()
        {
            return Enumerable.Range(1, 5).Select(index => new Produit
            {
                id = index,
                nom = $"produit{index}",
                texture = $"texture{index}",
                grammage = 10 + (990) * (float)Random.Shared.NextDouble(),
                prix = 1 + (999) * (float)Random.Shared.NextDouble(),
                couleur = $"couleur{index}",
            })
            .ToList();
        }
    }
}
