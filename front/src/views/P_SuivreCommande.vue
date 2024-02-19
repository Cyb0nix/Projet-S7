<!-- src/views/P_SuivreCommande.vue -->
<template>
  <div>
    <img src="../assets/pizza4.jpg" alt="Image d'accueil" class="home-image">
    <h2>Suivi de votre commande</h2>
    <div class="text" v-if="!phoneNumberEntered">
      <input custom-input v-model="phoneNumber" type="text" placeholder="Numéro de téléphone">
      <button  class="custom-button" @click="validatePhoneNumber">Valider</button>
    </div>
    <div v-else>
      <button :class="buttonClass" @click="changeStatus">{{ buttonText }}</button>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      phoneNumber: '',
      phoneNumberEntered: false,
      status: 'En attente de préparation'
    };
  },
  computed: {
    buttonText() {
      return `Etat de la Commande : ${this.status}`;
    },
    buttonClass() {
      return {
        'button-rounded': true,
        'en-attente': this.status === '../assets/pizza2',
        'en-cours': this.status === 'Commande en cours de préparation',
        'termine': this.status === 'Commande terminée',
        'attente-livreur': this.status === 'En attente d\'un livreur',
        'en-cours-livraison': this.status === 'En cours de livraison',
        'livraison-terminee': this.status === 'Livraison terminée'
      };
    }
  },
  methods: {
    changeStatus() {
  switch (this.status) {
    case 'En attente de préparation':
      this.status = 'Commande en cours de préparation';
      break;
    case 'Commande en cours de préparation':
      this.status = 'Commande terminée';
      break;
    case 'Commande terminée':
      this.status = 'En attente d\'un livreur';
      break;
    case 'En attente d\'un livreur':
      this.status = 'En cours de livraison';
      break;
    case 'En cours de livraison':
      this.status = 'Livraison terminée';
      break;
    case 'Livraison terminée':
      this.status = 'En attente de préparation';
      break;
    default:
      // Vous pouvez gérer un état par défaut si nécessaire.
      break;
  }
},
    validatePhoneNumber() {
      // Vous pouvez ajouter ici une validation du numéro de téléphone si nécessaire
      // Par exemple, assurez-vous que le numéro est au bon format.
      
      // Une fois que le numéro est validé, affichez le bouton d'état de commande.
      this.phoneNumberEntered = true;
    }
  }
};
</script>


  <style>

  h2{
    text-align:center;
  }
    .home-image {
  width: 100%;
  max-width: 800px;
  margin: 0 auto;
  display: block;
  text-align: center;
}

    .button-rounded {
      border-radius: 10%;
      width: 300px;
      height: 300px;
      font-size: 16px;
      text-align:center;
      margin-left:40%;
    }

    .en-attente {
       
    }

    .text{
      text-align:center;
    }

    .custom-button {
  background-color: #007BFF; /* Couleur de fond */
  color: #fff; /* Couleur du texte */
  border: none; /* Supprimer la bordure */
  border-radius: 4px; /* Coins arrondis */
  padding: 10px 20px; /* Espacement intérieur */
  cursor: pointer; /* Curseur pointer au survol */
  font-size: 16px; /* Taille de la police */
  text-align: center; /* Centrage du texte */
}

/* Style du bouton au survol */
.custom-button:hover {
  background-color: #0056b3; /* Couleur de fond au survol */
}

.custom-input {
  width: 100%; /* Largeur de 100% de son conteneur */
  padding: 10px; /* Espacement intérieur */
  border: 1px solid #ccc; /* Bordure légère */
  border-radius: 4px; /* Coins arrondis */
  font-size: 16px; /* Taille de la police */
  margin-bottom: 10px; /* Espacement en bas */
  box-sizing: border-box; /* Garde la largeur à 100% malgré la bordure */
}

/* Style de l'input au focus */
.custom-input:focus {
  border-color: #007BFF; /* Couleur de la bordure lors du focus */
}


    .en-cours {
      
    }

    .termine {
      
    }

    .attente-livreur {
      
    }

    .en-cours-livraison {
      
    }

    .livraison-terminee {
      
    }
  </style>


