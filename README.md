## Тестовое задание

В древней Гильдии состоят 60 торговцев. Каждый год они заключают друг с другом сделки. Ежегодно каждый торговец заключает сделки со всеми остальными членами Гильдии, от 5 до 10 сделок между каждой парой торговцев.

При свершении сделки у каждого из торговцев есть 2 варианта поведения: либо честно сотрудничать и выполнять все свои обязательства, либо сжульничать. От этого выбора зависит размер их прибыли:

* в том случае, если оба проводят сделку честно, оба зарабатывают по 4 золотых;
* если один торговец сжульничает, а другой продолжит честно сотрудничать, то жулик получит 5 золотых, а честный торогвец - всего 1;
* если оба сжульничают, то каждый получит только по 2 золотых.

Мерило успеха в Гильдии - прибыль, которую торговец заработал за последний год. В конце каждого года 20% самых неуспешных торговцев с позором исключают из Гильдии, а их место занимает ровно столько же новых, которые копируют поведение 20% самых успешных членов Гильдии.

Торговцы хранят коммерческую тайну, не распускают слухов и ничего не рассказывают другим о свершённых сделках.

У торговцев существуют следующие стандартные стратегии поведения:

| Название           | Описание                                                                                                                                                                                                      |
| ------------------ | --------                                                                                                                                                                                                      |
| _альтруист_        | Всегда сотрудничает.                                                                                                                                                                                          |
| _кидала_           | Всегда жульничает.                                                                                                                                                                                            |
| _хитрец_           | Начинает с сотрудничества, потом повторяет ход оппонента.                                                                                                                                                     |
| _непредсказуемый_  | Поступает случайным образом.                                                                                                                                                                                  |
| _злопамятный_      | Начинает с сотрудничества и продолжает сотрудничать, пока против него не сжульничают. После этого сам начинает постоянно жульничать.                                                                        |
| _ушлый_            | Всегда начинает с последовательности ходов: сотрудничество, жульничество, сотрудничество, сотрудничество. Далее, если к пятому ходу его хоть раз обманули, то играет как _кидала_, если нет, то как _хитрец_. |

В процессе сделки для каждого торговца существует 5% вероятность ошибиться и принять неправильное решение: сжульничать вместо того, чтобы сотрудничать, или наоборот.

Изначально в Гильдии состоит равное число торговцев, выступающих приверженцами каждой из перечисленных стратегий.
