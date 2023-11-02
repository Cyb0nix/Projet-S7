<template>

    <section
        class="relative bg-[url(https://images.unsplash.com/photo-1513104890138-7c749659a591?auto=format&fit=crop&q=80&w=2070&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D)] bg-cover bg-center bg-no-repeat"
    >
      <div
          class="absolute inset-0 bg-white/75 sm:bg-transparent sm:from-white/80 sm:to-white/10 sm:bg-gradient-to-r"
      ></div>

      <div
          class="relative mx-auto max-w-screen-xl px-4 py-32 sm:px-6 lg:flex lg:h-screen lg:items-center lg:px-8"
      >
        <div class="max-w-xl text-center ltr:sm:text-left rtl:sm:text-right">
          <h1 class="text-3xl font-extrabold sm:text-5xl">
            Bienvenue chez

            <strong class="block font-extrabold text-rose-700">
              PizzaDelice
            </strong>
          </h1>

          <p class="mt-4 max-w-lg sm:text-xl/relaxed">
            Découvrez nos délicieuses pizzas artisanales.
            <br>
            Tel : 07 82 35 28 44
            <br>
            Ouvert 7j/7, 11h-23h
          </p>
        </div>
      </div>
    </section>

    <br>

  <section>
    <div class="max-w-screen-xl px-4 py-8 mx-auto sm:px-6 sm:py-12 lg:px-8">
      <header class="text-center">
        <h2 class="text-xl font-bold text-gray-900 sm:text-3xl">
          Nos Pizzas
        </h2>

        <p class="max-w-md mx-auto mt-4 text-gray-500">
          Une sélection de nos meilleures pizzas, cuite au feu de bois, pâte maison.
        </p>
      </header>

      <ul class="grid gap-4 mt-8 sm:grid-cols-2 lg:grid-cols-4">
        <li>
          <a href="#" class="block overflow-hidden group">
            <img
                src="../assets/Pizzas/marguerita.png"
                alt=""
                class="h-[350px] w-full transition duration-500 group-hover:scale-105 sm:h-[300px]"
            />

            <div class="relative pt-3 bg-white">
              <h3
                  class="text-xs text-gray-700 group-hover:underline group-hover:underline-offset-4"
              >
                Margarita
              </h3>

              <p class="mt-2">
                <span class="tracking-wider text-gray-900"> Tomate, mozzarella, olives, origan.</span>
              </p>
            </div>
          </a>
        </li>

        <li>
          <a href="#" class="block overflow-hidden group">
            <img
                src="../assets/Pizzas/napolitaine.png"
                alt=""
                class="h-[350px] w-full transition duration-500 group-hover:scale-105 sm:h-[300px]"
            />

            <div class="relative pt-3 bg-white">
              <h3
                  class="text-xs text-gray-700 group-hover:underline group-hover:underline-offset-4"
              >
                Napolitaine
              </h3>

              <p class="mt-2">
                <span class="sr-only"> Regular Price </span>

                <span class="tracking-wider text-gray-900">Tomate, mozzarella, anchois, câpres, olives, origan.</span>
              </p>
            </div>
          </a>
        </li>

        <li>
          <a href="#" class="block overflow-hidden group">
            <img
                src="../assets/Pizzas/reine.png"
                alt=""
                class="h-[350px] w-full transition duration-500 group-hover:scale-105 sm:h-[300px]"
            />

            <div class="relative pt-3 bg-white">
              <h3
                  class="text-xs text-gray-700 group-hover:underline group-hover:underline-offset-4"
              >
                Reine
              </h3>

              <p class="mt-2">
                <span class="sr-only"> Regular Price </span>

                <span class="tracking-wider text-gray-900"> Tomate, mozzarella, délice de dinde, champignons, origan. </span>
              </p>
            </div>
          </a>
        </li>

        <li>
          <a href="#" class="block overflow-hidden group">
            <img
                src="../assets/Pizzas/4fromages.png"
                alt=""
                class="h-[350px] w-full transition duration-500 group-hover:scale-105 sm:h-[300px]"
            />

            <div class="relative pt-3 bg-white">
              <h3
                  class="text-xs text-gray-700 group-hover:underline group-hover:underline-offset-4"
              >
                4 Fromages
              </h3>

              <p class="mt-2">
                <span class="sr-only"> Regular Price </span>

                <span class="tracking-wider text-gray-900"> Tomate, mozzarella, brie, gorgonzola, parmesan, origan. </span>
              </p>
            </div>
          </a>
        </li>
      </ul>
    </div>
  </section>

    <br>

  <section>
    <div class="max-w-screen-xl px-4 py-8 mx-auto sm:px-6 sm:py-12 lg:px-8">
      <header class="text-center">
        <h2 class="text-xl font-bold text-gray-900 sm:text-3xl">
          Nos Boissons
        </h2>

        <p class="max-w-md mx-auto mt-4 text-gray-500">
          Une séléction de nos meilleures boissons.
        </p>
      </header>

      <ul class="grid gap-4 mt-8 sm:grid-cols-2 lg:grid-cols-4">
        <li>
          <a href="#" class="block overflow-hidden group">

            <div class="relative pt-3 bg-white">
              <p class="mt-2">
                <span class="tracking-wider text-gray-900">Coca-Cola</span>
              </p>
            </div>
          </a>
        </li>

        <li>
          <a href="#" class="block overflow-hidden group">
            <div class="relative pt-3 bg-white">

              <p class="mt-2">


                <span class="tracking-wider text-gray-900">Fanta</span>
              </p>
            </div>
          </a>
        </li>

        <li>
          <a href="#" class="block overflow-hidden group">

            <div class="relative pt-3 bg-white">

              <p class="mt-2">
                <span class="sr-only"> Regular Price </span>

                <span class="tracking-wider text-gray-900"> Sprit</span>
              </p>
            </div>
          </a>
        </li>

        <li>
          <a href="#" class="block overflow-hidden group">

            <div class="relative pt-3 bg-white">

              <p class="mt-2">

                <span class="text-center tracking-wider text-gray-900">Ice Tea</span>
              </p>
            </div>
          </a>
        </li>
      </ul>
    </div>
    <div class="mt-16 border-t border-gray-100 pt-8">
      <p class="text-center text-xs/relaxed text-gray-500">
        © DelicePizza 2023. All rights reserved.

        <br />
      </p>
    </div>
  </section>
</template>

<script>
export default {
  name: "P_Home",
};
</script>

<style scoped>

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

