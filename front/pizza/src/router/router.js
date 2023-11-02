import { createRouter, createWebHistory } from "vue-router";

import P_Home from '../views/P_Home.vue';
import P_Commande from '../views/P_Commande.vue';
import P_Cuisine from '../views/P_Cuisine.vue';
import P_Livreur from '../views/P_Livreur.vue';
import P_SeConnecter from '../views/P_SeConnecter.vue';
import P_SuivreCommande from '../views/P_SuivreCommande.vue';

const routes = [
    { path: "/", component: P_Home },
    { path: "/commande", component: P_Commande },
    { path: "/cuisine", component: P_Cuisine },
    { path: "/livreur", component: P_Livreur },
    { path: "/login", component: P_SeConnecter },
    { path: "/suivrecommande", component: P_SuivreCommande }, // Le nom doit être en minuscules
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;
