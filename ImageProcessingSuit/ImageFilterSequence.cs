using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class ImageFilterSequence : IImageFilter
    {
        private readonly List<IImageFilter> _filters;

        public ImageFilterSequence(IEnumerable<FilterType> filterTypes)
        {
            if (filterTypes == null)
            {
                throw new ArgumentNullException("filterTypes cannot be null");
            }

            _filters = new List<IImageFilter>();

            foreach (var filterType in filterTypes)
            {
                var filter = ImageFilterFactory.Get(filterType);
                _filters.Add(filter);
            }
        }

        public void Apply(Image inputImage)
        {
            foreach (var imageFilter in _filters)
            {
                imageFilter.Apply(inputImage);
            }
        }
    }
}
