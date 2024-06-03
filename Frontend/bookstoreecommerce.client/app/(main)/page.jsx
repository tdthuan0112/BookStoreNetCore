import Banner from "@/components/banner/banner";
import Advertising from "@/components/common/advertising";
import Articles from "@/components/article/articles";
import BookRecommendation from "@/components/book/book-recommendation";
import SubscribeEmail from "@/components/common/subscribe-email";

import { getAllBooksAction } from "@/actions/book-actions";

export default async function HomePage() {
  const books = await getAllBooksAction();

  //TODO
  function fetchBestOfTheMonth() {}

  return (
    <main>
      <Banner />
      <Advertising />
      <Articles />
      <BookRecommendation title="Best Seller" listBooks={books} />
      <BookRecommendation title="Best of the Month" listBooks={books} />
      <SubscribeEmail />
    </main>
  );
}
