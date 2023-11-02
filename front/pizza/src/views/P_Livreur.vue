<template>
  <div>
    <img src="../assets/pizza2.jpg" alt="Image d'accueil" class="home-image">
    <h1>Page Livreur</h1>

    <!-- Tableau des commandes à livrer -->
    <table class="delivery-table">
      <thead>
        <tr>
          <th>Numéro de Téléphone</th>
          <th>Commande</th>
          <th>État</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(commande, index) in commandesALivrer" :key="index">
          <td>{{ commande.telephone }}</td>
          <td>{{ commande.commande }}</td>
          <td>
            <button @click="changerEtat(commande)">
              {{ commande.etat }}
            </button>
          </td>
        </tr>
      </tbody>
    </table>

    <!-- Gestion des commandes terminées (automatiquement ajoutées) -->
    <table class="completed-table">
      <thead>
        <tr>
          <th>Numéro de Téléphone</th>
          <th>Commande</th>
          <th>État</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="(commande, index) in commandesTermines" :key="index">
          <td>{{ commande.telephone }}</td>
          <td>{{ commande.commande }}</td>
          <td>
            <button @click="changerEtat(commande)">
              {{ commande.etat }}
            </button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  name: "P_Livreur",
  data() {
    return {
      commandesALivrer: [],
      commandesTermines: [],
    };
  },
  methods: {
    changerEtat(commande) {
      if (commande.etat === "Attente") {
        commande.etat = "En cours de livraison";
      } else if (commande.etat === "En cours de livraison") {
        commande.etat = "Livré";
      }
    },
  },
  created() {
    // Simuler l'ajout automatique de commandes terminées
    setInterval(() => {
      const commandeTerminee = this.commandesALivrer.find(
        (commande) => commande.etat === "Terminé"
      );
      if (commandeTerminee) {
        this.commandesTermines.push({ ...commandeTerminee });
        const index = this.commandesALivrer.indexOf(commandeTerminee);
        this.commandesALivrer.splice(index, 1);
      }
    }, 5000); // Vérifier toutes les 5 secondes (ajustez selon vos besoins)
  },
};
</script>

<style scoped>
.home-image {
  width: 100%;
  max-width: 800px;
  margin: 0 auto;
  display: block;
  text-align: center;
}

/* Style de la page de livraison */
.delivery-table, .completed-table {
  width: 80%;
  margin: 20px auto;
  border-collapse: collapse;
}

.delivery-table th, .completed-table th,
.delivery-table td, .completed-table td {
  border: 1px solid #000;
  padding: 8px;
  text-align: center;
}

.delivery-table th, .completed-table th {
  background-color: #f1f1f1;
}

.delivery-table tbody tr:nth-child(odd), .completed-table tbody tr:nth-child(odd) {
  background-color: #e0e0e0;
}
</style>
