/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./Pages/*.{razor,html}",
    "./Layout/*.{razor, html}",
    "./wwwroot/**/*.{html,js}"
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}

