<template>
<body>
  <div class="app-container"> <!-- Ajoutez la classe "app-container" ici -->
    <NavBar />
    <router-view></router-view>
    <BasicFooter/>
  </div>
  </body>
</template>

<script>
import NavBar from './components/NavBar.vue';
import BasicFooter from './components/BasicFooter.vue';

export default {
  name: "App",
  components: {
    NavBar,
    BasicFooter,
  },
};
</script>

<style scoped>

.app-container {
  margin: 0; /* Supprimer les marges par défaut du corps de la page */
  padding: 0; /* Supprimer le rembourrage par défaut du corps de la page */
}


</style>
