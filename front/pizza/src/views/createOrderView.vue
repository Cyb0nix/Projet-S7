

<template>
  <section class="max-w-4xl p-6 mx-auto bg-white rounded-md shadow-md my-24">
    <h2 class="text-lg font-semibold text-gray-700 capitalize ">Ajouter une commande</h2>

    <form>
      <div class="grid grid-cols-1 gap-6 mt-4 sm:grid-cols-2">
        <div>
          <label class="text-gray-700 " for="surname">Telephone</label>
          <input id="customer" v-model="user.telephone" type="text" disabled class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>
        <div>
          <label class="text-gray-700 " for="firstname">Prénom</label>
          <input id="customerName" v-model="user.surname" disabled type="text" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>
        <div>
          <label class="text-gray-700 " for="pizzaType">Pizza Type</label>
          <input id="pizzaType" v-model="pizza.type" type="text" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>
        <div>
          <label class="text-gray-700 " for="pizzaSize">Pizza Size</label>
          <input id="pizzaSize" v-model="pizza.size" type="tel" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>
        <div>
          <label class="text-gray-700 " for="drinkType">Drink Type</label>
          <input id="drinkType" v-model="drink.type" type="text" class="block w-full px-4 py-2 mt-2 text-gray-700 bg-white border border-gray-200 rounded-md  focus:border-blue-400 focus:ring-blue-300 focus:ring-opacity-40  focus:outline-none focus:ring">
        </div>
      </div>

      <div class="flex justify-end mt-6">
        <button @click="addOrder()" class="px-8 py-2.5 leading-5 text-white transition-colors duration-300 transform bg-gray-700 rounded-md hover:bg-gray-600 focus:outline-none focus:bg-gray-600">Ajouter</button>
      </div>
    </form>
  </section>
</template>

<script>
  export default {
    name: "AddClient",
    data() {
      return {
        user:{
          surname: "",
          firstname: "",
          address: "",
          telephone: "",
        },
        newOrder: {
          customer: "",
          customerName: "",
          pizzas: [],
          drinks: [],
          status: "waiting"
        },
        pizza:
          {
            size: "",
            type: "",
            status: "waiting"
          },
        drink:
          {
            type: ""
          }
      };
    },
    methods: {
      async getUser() {
        try {
          const response = await fetch("http://localhost:5165/api/Customer/" + this.$route.params.user);
          this.user = await response.json();
        } catch (error) {
          console.log(error);
        }
      },
      async addOrder(){
        this.newOrder.customer = this.user.telephone;
        this.newOrder.customerName = this.user.surname;
        this.newOrder.pizzas.push(this.pizza);
        this.newOrder.drinks.push(this.drink);
        this.newOrder.status = "waiting";

        try {
          const response = await fetch("http://localhost:5165/api/Order?clerkId="+1, {
            method: "POST",
            headers: {
              "Content-Type": "application/json",
            },
            body: JSON.stringify(this.newOrder),
          });
          this.newOrder = await response.json();
        } catch (error) {
          console.log(error);

        }
      }


    },
    mounted() {
      this.getUser();
    }

  };

</script>

<style scoped>

</style>