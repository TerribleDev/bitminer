FROM ruby:alpine
RUN apk add --update build-base
RUN gem install bundle
RUN gem install thin
ADD Gemfile .
RUN bundle
ADD . .
CMD ["bundle", "exec", "thin",  "start"]
EXPOSE 80