<!-- src/views/P_Cuisine.vue -->
<template>
  <div class="text">
    <img src="../assets/pizza4.jpg" alt="Image d'accueil" class="home-image">
    <h1>Notre Cuisine</h1>

    <!-- Tableau des commandes -->
    <table class="command-table">
      <thead>
        <tr>
          <th>Numéro de Téléphone</th>
          <th>Commande</th>
          <th>État</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(commande, index) in commandes" :key="index">
          <td>{{ pizzas.type }}</td>
          <td>{{ pizzas.size }}</td>
          <td>
            <button @click="changerEtat(commande)">
              {{ commande.etat }}
            </button>
          </td>
        </tr>
      </tbody>
    </table>

    <!-- Formulaire pour ajouter une nouvelle commande -->
    <div class="add-command-form">
      <h2>Ajouter une Commande</h2>
      <form @submit.prevent="ajouterCommande">
        <div class="form-group">
          <label for="telephone">Numéro de Téléphone:</label>
          <input type="text" id="telephone" v-model="nouvelleCommande.telephone" required>
        </div>
        <div class="form-group">
          <label for="commande">Commande:</label>
          <input type="text" id="commande" v-model="nouvelleCommande.commande" required>
        </div>
        <button type="submit">Ajouter</button>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: "P_Cuisine",
  data() {
    return {
      commandes: [],
      nouvelleCommande: {
        telephone: "",
        commande: "",
        etat: "Attente",
      },
      pizzas: [],
    };
  },
  methods: {
    ajouterCommande() {
      this.commandes.push({ ...this.nouvelleCommande });
      // Réinitialiser le formulaire
      this.nouvelleCommande.telephone = "";
      this.nouvelleCommande.commande = "";
      this.nouvelleCommande.etat = "Attente";
    },
    changerEtat(commande) {
      if (commande.etat === "Attente") {
        commande.etat = "Préparation";
      } else if (commande.etat === "Préparation") {
        commande.etat = "Terminé";
      }
    },

   async getPizzas() {
      const response = await fetch("http://localhost:5165//api/Pizza");
      this.pizzas = await response.json();
    },
  },
};
</script>

<style scoped>
.text{
  text-align: center;
}
.home-image {
  width: 100%;
  max-width: 800px;
  margin: 0 auto;
  display: block;
  text-align: center;
}

/* Style de la page de cuisine */
.command-table {
  width: 80%;
  margin: 20px auto;
  border-collapse: collapse;
  background-color: #fff;
  border: 1px solid #ccc;
}

.command-table th,
.command-table td {
  border: 1px solid #ccc;
  padding: 8px;
  text-align: center;
}

.command-table th {
  background-color: #007BFF;
  color: #fff;
}

.command-table tbody tr:nth-child(odd) {
  background-color: #f1f1f1;
}

.add-command-form {
  margin-top: 20px;
}

.form-group {
  margin-bottom: 10px;
  text-align: center;
}

form label {
  display: block;
  margin-bottom: 5px;
  font-weight: bold;
}

form input {
  width: 50%;
  padding: 5px;
  border: 1px solid #ccc;
  border-radius: 4px;
}

button {
  background-color: #007BFF;
  color: #fff;
  border: none;
  border-radius: 4px;
  padding: 10px 20px;
  cursor: pointer;
  text-align: center;
}

button:hover {
  background-color: #0056b3;
}
</style>

