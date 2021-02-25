## AtlasCreator

You can use the [editor on GitHub](https://github.com/anomal3/AtlasCreator/edit/gh-pages/index.md) to maintain and preview the content for your website in Markdown files.

Whenever you commit to this repository, GitHub Pages will run [Jekyll](https://jekyllrb.com/) to rebuild the pages in your site, from the content in your Markdown files.

### Создание 4К текстуры

Метод создания 4К текстуры с входными параметрами

```markdown
  private void CreateImage4k(int AtlasSize, int PicImgSize)
        {
            using (Bitmap bmp = new Bitmap(AtlasSize, AtlasSize))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {

                    //g.DrawImage(pic1.Image, 0, 0, 2048, 2048);
                    //g.DrawImage(pic2.Image, 2048, 0, 2048, 2048);
                    //g.DrawImage(pic3.Image, 0, 2048, 2048, 2048);
                    //g.DrawImage(pic4.Image, 2048, 2048, 2048, 2048);
                    //bmp.Save(@"test.png");
                }
            }
        }
```


