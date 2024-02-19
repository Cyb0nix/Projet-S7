<template>
  <h1 class="class=text-2xl text-center my-15 font-bold sm:text-3xl mt-16">Commandes</h1>
  <div>
    <div class="flex flex-col mt-6 mx-16">
      <div class="-mx-4 -my-2 overflow-x-auto sm:-mx-6 lg:-mx-8">
        <div class="inline-block min-w-full py-2 align-middle md:px-6 lg:px-8">
          <div class="overflow-hidden border border-gray-200 md:rounded-lg">
            <table class="min-w-full divide-y divide-gray-200 ">
              <thead class="bg-gray-50">
              <tr>
                <th scope="col" class="py-3.5 px-4 text-sm font-normal text-left rtl:text-right text-gray-500 ">
                    <span>Numéro de Téléphone</span>


                </th>

                <th scope="col" class="py-3.5 px-4 text-sm font-normal text-left rtl:text-right text-gray-500 ">
                  <button class="flex items-center gap-x-2 focus:outline-none">
                    <span>Commande</span>

                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" d="M12 6v6m0 0v6m0-6h6m-6 0H6"></path>
                    </svg>
                  </button>
                </th>

                <th scope="col" class="py-3.5 px-4 text-sm font-normal text-left rtl:text-right text-gray-500 ">
                  <button class="flex items-center gap-x-2 focus:outline-none">
                    <span>Date</span>

                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" d="M12 6v6m0 0v6m0-6h6m-6 0H6"></path>
                    </svg>
                  </button>
                </th>

                <th scope="col" class="py-3.5 px-4 text-sm font-normal text-left rtl:text-right text-gray-500 ">
                  <button class="flex items-center gap-x-2 focus:outline-none">
                    <span>Heure</span>

                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" d="M12 6v6m0 0v6m0-6h6m-6 0H6"></path>
                    </svg>
                  </button>
                </th>

                <th scope="col" class="py-3.5 px-4 text-sm font-normal text-left rtl:text-right text-gray-500 ">
                  <button class="flex items-center gap-x-2 focus:outline-none">
                    <span>Etat</span>

                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor">
                      <path stroke-linecap="round" stroke-linejoin="round" d="M12 6v6m0 0v6m0-6h6m-6 0H6"></path>
                    </svg>
                  </button>
                </th>

              </tr>
              </thead>

              <tbody class="bg-white divide-y divide-gray-200 ">
              <tr v-for="(order,index) in orders" :key="index" >
                <td class="py-3 px-4 text-sm font-normal text-gray-700 ">{{order.customer}}</td>

                <td class="py-3 px-4 text-sm font-normal text-gray-700 ">{{order.customerName}}</td>

                <td class="py-3 px-4 text-sm font-normal text-gray-700 ">{{order.date}}</td>

                <td class="py-3 px-4 text-sm font-normal text-gray-700 ">{{order.time}}</td>

                <td class="py-3 px-4 text-sm font-normal text-gray-700 ">{{order.status}}</td>

                <td class="py-3 px-4 text-sm font-medium text-right rtl:text-left" v-if="order.status === 'Pending'">
                  <button class="flex items-center text-green-500 hover:underline focus:outline-none" @click="prepare(order.orderNumber)">
                    <span>Prête</span>
                  </button>
                </td>
                <td class="py-3 px-4 text-sm font-medium text-right rtl:text-left" v-if="order.status === 'Ready'">
                  <button class="flex items-center text-blue-500 hover:underline focus:outline-none" @click="deliver(order.orderNumber)">
                    <span>Livrer</span>
                  </button>
                </td>
                <td class="py-3 px-4 text-sm font-medium text-right rtl:text-left">
                  <button class="flex items-center text-blue-500 hover:underline focus:outline-none" @click="cancel(order.orderNumber)">
                    <span>Annuler</span>
                  </button>
                </td>
              </tr>

              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "OrderView",
  data() {
    return {
      orders: []
    };
  },
  methods: {
    async getOrders() {
      this.orders = [];
      try {
        const response = await fetch("http://localhost:5165/api/Order/All",
            {
              method: "GET",
              headers: {
                "Content-Type": "application/json",
              },
            });
        this.orders = await response.json();
      } catch (error) {
        console.log(error);
      }
    },
    async prepare(id){
      try {
        const response = await fetch("http://localhost:5165/api/Order/prepare/"+id,
            {
              method: "PUT",
              headers: {
                "Content-Type": "application/json",
              },
            });
        this.orders = await response.json();
      } catch (error) {
        console.log(error);
      }
      await this.getOrders();
    },
    async deliver(id){
      try {
        const response = await fetch("http://localhost:5165/api/Order/deliver/"+id,
            {
              method: "PUT",
              headers: {
                "Content-Type": "application/json",
              },
            });
        this.orders = await response.json();
      } catch (error) {
        console.log(error);
      }

      await this.getOrders();
    },
    async cancel(id){
      try {
        const response = await fetch("http://localhost:5165/api/Order/cancel/"+id,
            {
              method: "PUT",
              headers: {
                "Content-Type": "application/json",
              },
            });
        this.orders = await response.json();
      } catch (error) {
        console.log(error);
      }

      await this.getOrders();
    }
  },

  mounted() {
    this.getOrders();
  }
};
</script>

<style scoped>

</style>
