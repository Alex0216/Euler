#include "BinaryTree.h"

#include <queue>
#include <iostream>

BinaryTree::BinaryTree()
{
}


BinaryTree::~BinaryTree()
{
}

void BinaryTree::PrintTree() const
{
    std::queue<Node*> queue;

    queue.push(Head.get());
    std::queue<int> valueList;
    valueList.push(Head->Value);

    while (!queue.empty())
    {
        auto node = queue.front();
        queue.pop();

        valueList.push(node->Left->Value);
        valueList.push(node->Right->Value);

        if (node->Left != nullptr)
            queue.push(node->Left.get());
        if (node->Right != nullptr)
            queue.push(node->Right.get());
    }

    int nbToPrint = 1;

    while (!valueList.empty())
    {
        for (int i = 0; i < nbToPrint; ++i)
        {
            if (valueList.empty())
                return;
            std::cout << valueList.front() << " ";
            valueList.pop();
        }

        nbToPrint *= 2;
    }


}
