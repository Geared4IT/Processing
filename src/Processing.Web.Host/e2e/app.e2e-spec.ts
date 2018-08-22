import { ProcessingTemplatePage } from './app.po';

describe('Processing App', function() {
  let page: ProcessingTemplatePage;

  beforeEach(() => {
    page = new ProcessingTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
