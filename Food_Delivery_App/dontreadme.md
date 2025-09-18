
📦 Food Delivery App (Angular + JSON Server)

📂 Project Structure

food-delivery-app/
├── src/
│   ├── app/
│   │   ├── models/
│   │   │   ├── user.model.ts
│   │   │   ├── dish.model.ts
│   │   │   ├── restaurant.model.ts
│   │   │   └── cart-item.model.ts
│   │   ├── services/
│   │   │   ├── user.service.ts
│   │   │   └── cart.service.ts
│   │   ├── user/
│   │   │   ├── user.component.ts
│   │   │   └── user.component.html
│   │   ├── restaurants/
│   │   │   ├── restaurants.component.ts
│   │   │   └── restaurants.component.html
│   │   ├── menu/
│   │   │   ├── menu.component.ts
│   │   │   └── menu.component.html
│   │   ├── cart-summary/
│   │   │   ├── cart-summary.component.ts
│   │   │   └── cart-summary.component.html
│   │   ├── checkout/
│   │   │   ├── checkout.component.ts
│   │   │   └── checkout.component.html
│   │   ├── app.module.ts
│   │   └── app.component.ts
│   └── index.html
├── db.json               # JSON Server mock backend
├── package.json
└── README.md


---

🚀 Features

User Credentials Page → Save user details (name, location, phone) in localStorage.

Restaurants Page → Fetch restaurants from db.json.

Menu Page → View dishes of a restaurant and add to cart.

Global Cart → Supports items from multiple restaurants (stored in sessionStorage).

Cart Summary Page → Displays all items, quantities, and total.

Checkout Page → Clears cart and shows order success message.



---

⚙️ Setup Instructions

1. Install Angular CLI (if not already)

npm install -g @angular/cli

2. Create Angular Project

ng new food-delivery-app
cd food-delivery-app

When prompted → Choose Yes for routing and CSS for styles.

3. Add Dependencies

npm install

4. Add JSON Server for mock backend

npm install -g json-server

5. Place db.json in root folder

{
  "restaurants": [
    {
      "id": 1,
      "name": "Spicy Treat",
      "menu": [
        { "id": 1, "name": "Paneer Butter Masala", "price": 200 },
        { "id": 2, "name": "Chicken Curry", "price": 250 }
      ]
    },
    {
      "id": 2,
      "name": "Tandoori Hub",
      "menu": [
        { "id": 1, "name": "Tandoori Roti", "price": 40 },
        { "id": 2, "name": "Dal Tadka", "price": 150 }
      ]
    },
    {
      "id": 3,
      "name": "Pizza World",
      "menu": [
        { "id": 1, "name": "Veggie Pizza", "price": 300 },
        { "id": 2, "name": "Pepperoni Pizza", "price": 400 }
      ]
    }
  ]
}

6. Start JSON Server

json-server --watch db.json --port 3000

API available at:

http://localhost:3000/restaurants

http://localhost:3000/restaurants/:id


7. Run Angular App

ng serve

App runs at: http://localhost:4200


---

🖥️ Usage Flow

1. Open http://localhost:4200


2. Fill in User Credentials → Continue


3. Select a Restaurant


4. View Menu → Add items to cart (can add from multiple restaurants)


5. Open Cart Summary → Review items & total


6. Click Pay & Place Order → Redirects to checkout success screen




---

✅ Next Improvements

Add Route Guards → prevent accessing restaurants if user not set.

Add Quantity controls (+/- buttons).

Add Order history stored in localStorage.

Add Bootstrap/Material UI for styling.



---

Would you like me to also generate this README.md as a file (so you can download it along with all source files)?


