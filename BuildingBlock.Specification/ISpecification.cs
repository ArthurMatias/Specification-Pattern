using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Specification
{
    //Generic interfaces definitions
    //http://share.linqpad.net/rtex3r.linq
    public interface ISpecification<in T, in TVisitor> where TVisitor : ISpecificationVisitor<TVisitor, T>
    {
        bool IsSatisfiedBy(T item);
        void Accept(TVisitor visitor);
    }

    public interface ISpecificationVisitor<TVisitor, T> where TVisitor : ISpecificationVisitor<TVisitor, T>
    {
        void Visit(AndSpecification<T, TVisitor> spec);
        void Visit(OrSpecification<T, TVisitor> spec);
        void Visit(NotSpecification<T, TVisitor> spec);
    }

    //Specific implementation
  /*  public interface IProductSpecificationVisitor : ISpecificationVisitor<IProductSpecificationVisitor, Product>
    {
        void Visit(ProductMatchesCategory spec);
        void Visit(ProductPriceInRange spec);
    }

    public class ProductMatchesCategory : ISpecification<Product, IProductSpecificationVisitor>
    {
        public readonly string Category;

        public ProductMatchesCategory(string category)
        {
            this.Category = category;
        }

        public bool IsSatisfiedBy(Product item) => item.Category == Category;

        public void Accept(IProductSpecificationVisitor visitor)
        {
            visitor.Visit(this);
        }
    }*/
}
