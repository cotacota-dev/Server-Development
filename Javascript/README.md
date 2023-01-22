## express-generatorによるテンプレートの作成
```javascript
npx express-generator --no-view server
cd server
npm install
```

## nodemonで自動で再起動する
```javascript
npm install nodemon -D
```
### package.jsonのscriptsに追記
```
"scripts": {
    "start": "node ./bin/www",
    "dev": "nodemon ./bin/www"
}
```

## Sequelizeでデータベースへアクセス(PostgreSQL)
```javascript
npm install sequelize
npm install pg pg-hstore
```