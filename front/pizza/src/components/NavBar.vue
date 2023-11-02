<!-- src/components/NavBar.vue -->
<template>
  <header class="bg-white">
    <div
        class="mx-auto flex h-16 max-w-screen-xl items-center gap-8 px-4 sm:px-6 lg:px-8"
    >
      <a class="block text-grey-600">
        <span class="sr-only">Home</span>
        <img src="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAACXBIWXMAAAsTAAALEwEAmpwYAAAEHklEQVR4nNWabYhWRRTHf+WapT6+a7aJiSkavmSSgSyKiugnKZRVAlNUEBJJJXFNSyKQhEpRMlT8mKKighpYqGiBfUowX8p38yVdNRVN0W21Jw6cC8Pt3rkz997n2Wf/cGB378yZ85+XM/+ZWcgXQ4HzwAVgM/A20IpmiENAMWR3gY3AAJoJegL/RhAJTL7tAWqocNRZSITtJ2AEFYqjHkQC2wq8QgWhfwoSgT3U0XyWCsCnGYgEdhB4uamJjAd2AQ0ZydwAxlAB6AIsAi5mIPMEmNcUwa8HvgDeMP7WAqgFfstA6HPgmXKR6KU9GDT+CzATeN4gND3DCK0vF5kVMQHc1EwUEGqpv/+TgsyKUpNopQHbgvgDeM+o8yZwLAWZD0pJZKpHID/oNBQ8p/PfJmeKIWsspRL42bNX/9aeDTa+icB9j/p/Ai/mTWJIhmy0F+ikfiTT1XvU3ZE3kQ3qeIMG1QYYBex2DEjOLK+pr766llzJTM6LRAfggc7xfhHflzgGdAsYZpBxHZlrQCEPIvPU4T5LmT2OQckaecuYZvfKlZJlczqlzmSxxmG0x1S5ZUyzdxyz2WOgRxYiY9XRVaDKUq7gmQBk5++sdZc71lmThchOdbIsoVy7FNlsv0qaKpU6SeUfAdVpSPTQjanRwcEYSwANqpCr1eoM+b/QuI1pdCDzZRoin2nlkw5C7jtL4xJ43Hn/IfBqgo4z7YFmUWeI6LtuOFhuIfNxQuNRo1ltfD+gvl8AzjiQme9DZEqMfhqnG2JbnU62kQgs2NVNdAqVmaV/r3Xwd9pH6v+YYvHG7eh9HDbRazoiost+dfArHZqIgTmROKtH4TBaxEiUBcbekuR7mwuRtTkRkWkSh3cjyterhpNpczzB919JJAqeUttmwYYXhfYxdebq9/cTfMv0s2JOTiSKCUIvjsgJhw4VEq8nEUkaUh+TuR6HyZZ6NVpmW+iQtQoY7pKxRnoGehmYpL1X0MADgVnUnztGtCNT7orF70otJ/7W6bnH63p1iyeJqP2ho34zy9WqFmunI2EjUdQHo9R4Sa9uRO/0jtBEYZORiIPLpha2+8A3wCAy4hN1uN3xDaSQkxI+rgkmlxNglTHccv4w0T0mANvtRteE4Bt0IUtbud4qTtQGzkQ4NsWdaaLFfDY7sUvA0lJc8QTYrw19zf+xOCaoC9rzJkQrzQgt9qfA9/raK9KkZOhnnJllyD/U9Ji02IPj6lRdoF8Bt41vt/UQFCUYS4LVKTKMzeTIOhtoTRnRGriTQ/CPdfE22TP07Bxkel2COCwLjqQI/qle1E0o5+uSDTWeBOr1cqCi3sgF33os3ml6GVFx6KKXXTbdI295g6lwfBRD4He9sJYbkmaBc6HUuak5/AcPETis1zQiP7o1dTBp8R9YdMXQg8QEcQAAAABJRU5ErkJggg==">
        </a>

      <div class="flex flex-1 items-center justify-end md:justify-between">
        <nav aria-label="Global" class="hidden md:block">
          <ul class="flex items-center gap-6 text-sm">
            <li>
              <router-link to="/" class="text-gray-500 transition hover:text-gray-500/75">
                Acceuil
              </router-link>
            </li>

            <li>
              <router-link to="/commande" class="text-gray-500 transition hover:text-gray-500/75" >
                Client
              </router-link>
            </li>

            <li>
              <router-link to="/livreur" class="text-gray-500 transition hover:text-gray-500/75" >
                Livreur
              </router-link>
            </li>

            <li>
              <router-link to="suivrecommande" class="text-gray-500 transition hover:text-gray-500/75" >
                Suivre sa commande
              </router-link>
            </li>
          </ul>
        </nav>

        <div class="flex items-center gap-4">
          <div class="sm:flex sm:gap-4">
            <a
                class="block rounded-md bg-gray-700 px-5 py-2.5 text-sm font-medium text-white transition hover:bg-gray-900"
                href="/login"
            >
              Login
            </a>
          </div>

          <button
              class="block rounded bg-gray-100 p-2.5 text-gray-600 transition hover:text-gray-600/75 md:hidden"
          >
            <span class="sr-only">Toggle menu</span>
            <svg
                xmlns="http://www.w3.org/2000/svg"
                class="h-5 w-5"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
                stroke-width="2"
            >
              <path
                  stroke-linecap="round"
                  stroke-linejoin="round"
                  d="M4 6h16M4 12h16M4 18h16"
              />
            </svg>
          </button>
        </div>
      </div>
    </div>
  </header>
</template>

<script>
export default {
  name: "NavBar",
};
</script>

