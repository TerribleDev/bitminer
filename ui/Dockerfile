FROM node:boron-wheezy
RUN npm install -g bower
ADD package.json .
RUN npm install
ADD bower.json
RUN bower install
ADD . .
EXPOSE 3000
CMD ["npm", "run", "start"]

