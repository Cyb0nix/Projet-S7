import { createRouter, createWebHistory } from "vue-router";

import P_Home from '../views/HomeView.vue';
import P_Commande from '../views/ClientsView.vue';
import P_Cuisine from '../views/P_Cuisine.vue';
import P_Livreur from '../views/P_Livreur.vue';
import P_SeConnecter from '../views/P_SeConnecter.vue';
import P_SuivreCommande from '../views/P_SuivreCommande.vue';
import addUserView from '../views/addUserView.vue';
import createOrderView from '../views/createOrderView.vue';

const routes = [
    { path: "/", component: P_Home },
    { path: "/clients", component: P_Commande },
    { path: "/cuisine", component: P_Cuisine },
    { path: "/commandes", component: P_Livreur },
    { path: "/login", component: P_SeConnecter },
    { path: "/suivrecommande", component: P_SuivreCommande }, // Le nom doit être en minuscules
    { path: "/createaccount", component: addUserView},
    {path: "/createorder/:user",name: "createorder" ,component: createOrderView}
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
