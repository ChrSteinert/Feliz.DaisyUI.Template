const HtmlWebpackPlugin = require('html-webpack-plugin');
const path = require('path');

module.exports = {
    entry: './fable/App.js',
    devServer: {
        server: 'http',
        static: [ './public' ]
    },
    plugins: [ new HtmlWebpackPlugin({
        filename: 'index.html',
        template: './src/index.html'
    }) ]
}