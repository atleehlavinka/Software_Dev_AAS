const App = {
  data() {
    return {
      displayCart: false,
      displayLabels: true,
      cart: [],
      products : [
        {
          "id": "001",
          "name": "Chess Board",
          "price": "45",
          "image": "media/store/pixabay-boardgame.jpg"
        },
        {
          "id": "002",
          "name": "Candle",
          "price": "22",
          "image": "media/store/pixabay-candle.jpg"
        },
        {
          "id": "003",
          "name": "Card",
          "price": "12",
          "image": "media/store/pixabay-card.jpg"
        },
        {
          "id": "004",
          "name": "Coffee Bag",
          "price": "14",
          "image": "media/store/pixabay-coffee.jpg"
        },
        {
          "id": "005",
          "name": "Rock",
          "price": "4",
          "image": "media/store/pixabay-crystal.jpg"
        },
        {
          "id": "006",
          "name": "Cutting Board",
          "price": "26",
          "image": "media/store/pixabay-cuttingboard.jpg"
        },
        {
          "id": "007",
          "name": "Honey",
          "price": "22",
          "image": "media/store/pixabay-honey.jpg"
        },
        {
          "id": "008",
          "name": "Hot Chocolate",
          "price": "8",
          "image": "media/store/pixabay-hotchocolate.jpg"
        },
        {
          "id": "009",
          "name": "Monopoly",
          "price": "42",
          "image": "media/store/pixabay-monopoly.jpg"
        },
        {
          "id": "010",
          "name": "Rug",
          "price": "56",
          "image": "media/store/pixabay-rug.jpg"
        },
        {
          "id": "011",
          "name": "Snow Globe",
          "price": "30",
          "image": "media/store/pixabay-snowglobe.jpg"
        },
        {
          "id": "012",
          "name": "Paper and Pen",
          "price": "27",
          "image": "media/store/pixabay-writing.jpg"
        }
      ]
    }
  },
  computed: {
    filteredProducts() {
      return this.products.filter(item => (item.price))
    },
    cartTotal() {
      return this.cart.reduce((inc, item) => Number(item.price) + inc, 0)
    }
  },
  methods: {
    addToCart(product) {
      this.cart.push(product)
    },
    currency(value) {
      return `$${Number.parseFloat(value).toFixed(2)}`
    }
  }
}

Vue.createApp(App).mount('#app')