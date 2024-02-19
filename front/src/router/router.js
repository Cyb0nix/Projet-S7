import { createRouter, createWebHistory } from "vue-router";

import P_Home from '../views/HomeView.vue';
import P_Commande from '../views/ClientsView.vue';
import P_Cuisine from '../views/P_Cuisine.vue';
import OrderView from '../views/OrderView.vue';
import P_SeConnecter from '../views/P_SeConnecter.vue';
import P_SuivreCommande from '../views/P_SuivreCommande.vue';
import addUserView from '../views/addUserView.vue';
import createOrderView from '../views/createOrderView.vue';

const routes = [
    { path: "/", component: P_Home },
    { path: "/clients", component: P_Commande, name: "clients" },
    { path: "/cuisine", component: P_Cuisine, name: "cuisine" },
    { path: "/commandes", component: OrderView, name: "commandes" },
    { path: "/login", component: P_SeConnecter, name: "login" },
    { path: "/suivrecommande", component: P_SuivreCommande, name: "suivrecommande"},
    { path: "/createaccount", component: addUserView, name: "createaccount"},
    {path: "/createorder/:user",name: "createorder" ,component: createOrderView}
];

const router = createRouter({
  history: createWebHistory(),
  routes
});

export default router;
