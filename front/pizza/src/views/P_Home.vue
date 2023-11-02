<template>
  <div class="home-container">
    <div class="content">
      <div class="left-content">
        <h1>Bienvenue chez DelicePizza</h1>
        <p>Découvrez nos délicieuses pizzas artisanales.</p>
        <p>Tel : 07 82 35 28 44</p>
        <p>Ouvert 7j/7, 11h-23h</p>
      </div>
      <img src="@/assets/pizza4.jpg" alt="Image d'accueil" class="home-image">
      <div class="right-content">
        <div class="social-icon">
          <a href="https://www.facebook.com" class="icon"><img src="@/assets/facebook.png" alt="Facebook"></a>
          <a href="https://www.instagram.com" class="icon"><img src="@/assets/instagram.png" alt="Instagram"></a>
          <a href="https://twitter.com" class="icon"><img src="@/assets/twitter.png" alt="Twitter"></a>
        </div>
      </div>
    </div>

    <br>

    <div class="section">
      <h1>Nos Pizzas</h1>
      <div class="pizza-grid">
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/marguerita.png" alt="Nom de la pizza">
              <h2>Margerita</h2>
              <p>Tomate, mozzarella, olives, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/napolitaine.png" alt="Nom de la pizza">
              <h2>Napolitaine</h2>
              <p>Tomate, mozzarella, anchois, câpres, olives, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/reine.png" alt="Nom de la pizza">
              <h2>Reine</h2>
              <p>Tomate, mozzarella, délice de dinde, champignons, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/vegeratienne.png" alt="Nom de la pizza">
              <h2>Végétarienne</h2>
              <p>Tomate, mozzarella, tomates fraîches, poivrons, oignons, champignons, olives, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/4fromages.png" alt="Nom de la pizza">
              <h2>4 Fromages</h2>
              <p>Tomate, mozzarella, brie, gorgonzola, parmesan, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/orientale.png" alt="Nom de la pizza">
              <h2>Oriantale</h2>
              <p>Tomate, mozzarella, merguez, oignons, poivrons, champignons, oeuf, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/mexicaine.png" alt="Nom de la pizza">
              <h2>Mexicaine</h2>
              <p>Tomate, mozzarella, délice de dinde, viande hachée, oeuf, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/campione.png" alt="Nom de la pizza">
              <h2>Campione</h2>
              <p>Tomate, mozzarella, viande hachée, champignons, oeuf, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/deluxe.png" alt="Nom de la pizza">
              <h2>Deluxe</h2>
              <p>Tomate, mozzarella, chorizo de boeuf, oignons, viande hachée, champignons, poivrons, origan.</p>
            </div>
          </div>
        </div>
        <div class="pizza-box">
          <div class="pizza">
            <div class="pizza-info">
              <img src="../assets/Pizzas/texmex.png" alt="Nom de la pizza">
              <h2>Tex Mex</h2>
              <p>Tomate, mozzarella, oignons, merguez, viande hachée, piments verts, origan.</p>
            </div>
          </div>
        </div>
      </div>
    </div>

    <br>

    <section class="section">
      <h2>Nos Boissons</h2>
      <div class="drink-grid">
        <div class="drink-box">
          <div class="drink">
            <p>Ice Tea</p>
          </div>
        </div>
        <div class="drink-box">
          <div class="drink">
            <p>Coca Cola</p>
          </div>
        </div>
        <div class="drink-box">
          <div class="drink">
            <p>Sprite</p>
          </div>
        </div>
        <div class="drink-box">
          <div class="drink">
            <p>Fanta</p>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
export default {
  name: "P_Home",
};
</script>

<style scoped>
/* Style de la page d'accueil */
.home-container {
  width: 100%;
  background-color: #fff; /* Arrière-plan blanc */
  display: flex;
  flex-direction: column; /* Disposition en colonne */
  align-items: center;
  justify-content: center; /* Centrage vertical et horizontal */
}

/* Style de la section d'accueil */
.content {
  display: flex;
  justify-content: space-between;
  align-items: center;
  width: 80%;
  max-width: 1200px;
  padding: 20px;
  flex: 1; /* Pour occuper l'espace vertical disponible */
}

.left-content {
  color: #000; /* Texte en noir */
  flex: 1;
  margin-left: 10;
  border: 1px solid #ccc; /* Bordure pour séparer les sections */
  border-radius: 10px; /* Coins arrondis */
  padding-left:15px;
}

.home-image {
  width: 70%;
  max-width: 800px;
  flex: 1;
  margin: 20px;
}

.right-content img{
  display: flex;
  flex-direction: column; /* Aligner les icônes en colonne */
  align-items: flex-end;
  flex: 1;
  margin-right: 0;
  width: 30px; /* Largeur de l'icône */
  height: auto; /* Hauteur de l'icône */
}


/* Style des sections */
.section {
  margin: 20px 0;
  width: 80%;
  max-width: 1200px;
  padding: 20px;
  border: 1px solid #ccc; /* Bordure pour séparer les sections */
  border-radius: 10px; /* Coins arrondis */
  flex: 1; /* Pour occuper l'espace vertical disponible */
  display: flex;
  flex-direction: column; /* Disposition en colonne */
  background-color: #272827;
}

.section h2 {
  font-size: 1.5rem;
  font-family: 'Blackscript';
}
.section h1 {
  font-size: 1.5rem;
  color: #856d4d;
}
@font-face {
  font-family: 'Blackscript';
  src: url('@/assets/police/blackscript.ttf') format('truetype');
}
h1{
  font-family: 'Blackscript';
}

/* Style de la grille de pizzas et boissons */
.pizza-grid,
.drink-grid {
  display: grid;
  grid-template-columns: repeat(2, 1fr); /* 2 colonnes égales */
  gap: 20px; /* Espace entre les boîtes */
}

/* Style des boîtes de pizzas et boissons */
.pizza-box,
.drink-box {
  border: 1px solid #000; /* Bordure de la boîte */
  border-radius: 10px; /* Coins arrondis */
  padding: 10px; /* Espace à l'intérieur de la boîte */
  display: flex; /* Utilisation de flexbox pour aligner les éléments */
  align-items: center; /* Aligner verticalement au centre */
  background-color: #856d4d;
}

.pizza img {
  max-width: 300px; /* Ajustez la largeur maximale de l'image selon vos besoins */
  margin-right: 10px; /* Espace à droite de l'image */
  border-radius: 5%;
}

.pizza-info {
  flex: 1; /* Utilisez tout l'espace disponible à droite de l'image */
  display: flex; /* Utilisation de flexbox pour aligner les éléments horizontalement */
  align-items: center; /* Aligner verticalement au centre */
  justify-content: space-between;
}

/* Style du titre de la pizza et de la description */
.pizza-info h2,
.pizza-info p {
  margin: 10px;
}

.pizza-info p {
  flex-direction: column; /* Aligner les icônes en colonne */
  align-items: flex-end;
}

/* Style des éléments de boisson */
.drink {
  text-align: center;
}
</style>

